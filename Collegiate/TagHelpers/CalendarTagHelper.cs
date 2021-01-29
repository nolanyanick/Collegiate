using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Collegiate.Models;
using System.Xml.Linq;
using Collegiate.Data;

namespace Collegiate.TagHelpers
{
    [HtmlTargetElement("calendar", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class CalendarTagHelper : TagHelper
    {
        #region FIELDS

        private int _month;
        private int _year;
        private ICollection<DriverOffer> _offers; //check the database. if there are offers add them to the list. store that list in this field. 
        private ICollection<RiderRequest> _requests;
        private List<DateTime> _dates;
        private List<DriverOffer> _dailyOffers;
        private DateTime _currentDate;
        private ICollection<RiderRequest> _dailyRequests;
        private readonly ApplicationDbContext _db; //database    

        #endregion

        #region PROPERTIES

        public ICollection<DriverOffer> Offers
        {
            get { return _offers; }
            set { _offers = value; }
        }
        public ICollection<RiderRequest> Requests
        {
            get { return _requests; }
            set { _requests = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }

        public List<DateTime> Dates
        {
            get { return _dates; }
            set { _dates = value; }
        }

        public DateTime CurrentDate
        {
            get { return _currentDate; }
            set { _currentDate = value; }
        }

        public List<DriverOffer> DailyOffers
        {
            get { return _dailyOffers; }
            set { _dailyOffers = value; }
        }

        public ICollection<RiderRequest> DailyRequests
        {
            get { return _dailyRequests; }
            set { _dailyRequests = value; }
        }

        #endregion

        #region METHODS

        //constructor
        public CalendarTagHelper(ApplicationDbContext db)
        {
            _db = db;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            output.Attributes.Add("class", "calendar");
            output.Content.SetHtmlContent(GetHtml());
            output.TagMode = TagMode.StartTagAndEndTag;
        }

        //generates calendar html
        private string GetHtml()
        {
            //current month
            var monthStart = new DateTime(Year, Month, 1);

            //generate calendar body
            var html = new XDocument(
                new XElement("div",
                    new XAttribute("class", "container-fluid w-76"),
                    new XElement("header",

                        //title
                        new XElement("h4",
                            new XAttribute("class", "display-4 mb-2 text-center"),

                            //form to submit user's request to change the month of the calendar
                            new XElement("form",

                                //button to navigate to previous month
                                new XElement("button",
                                new XAttribute("class", "btn btn-lg m-2 mt-0 p-1"),
                                new XAttribute("name", "buttonName"),
                                new XAttribute("value", "prevMonth"),
                                new XAttribute("type", "submit"),
                                monthStart.Month == 1 ? new XAttribute("disabled", "true") : null,
                                HttpUtility.HtmlDecode("&#x276C;")),

                                //date
                                monthStart.ToString("MMMM, "),
                                monthStart.Year.ToString(),

                                //button to navigate to next month
                                new XElement("button",
                                new XAttribute("class", "btn btn-lg m-2 p-1"),
                                new XAttribute("name", "buttonName"),
                                new XAttribute("value", "nextMonth"),
                                new XAttribute("type", "submit"),
                                monthStart.Month == 12 ? new XAttribute("disabled", "true") : null,
                                HttpUtility.HtmlDecode("&#x276D;"))
                            )
                        ),

                        //days of the week
                        new XElement("div",
                            new XAttribute("class", "row d-none d-lg-flex bg-success text-white"),
                            Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().Select(d =>
                                new XElement("h6",
                                    new XAttribute("class", "col-lg p-1 text-center"),
                                    d.ToString()
                                )
                            )
                        )
                    ),

                    //generate dates
                    new XElement("div",
                    new XAttribute("class", "row border border-right-0 border-bottom-0"),
                        GetDatesHtml()
                    )
                )
            );

            return html.ToString();
        }

        //dates
        IEnumerable<XElement> GetDatesHtml()
        {
            //current month
            var monthStart = new DateTime(Year, Month, 1);

            //start date
            var startDate = monthStart.AddDays(-(int)monthStart.DayOfWeek);

            //dates, Range(0, 42) to account for days of previous month and next month
            var dates = Enumerable.Range(0, 42).Select(i => startDate.AddDays(i));

            foreach (var d in dates)
            {
                //generate html element to 
                if (d.DayOfWeek == DayOfWeek.Sunday && d != startDate)
                {
                    yield return new XElement("div",
                        new XAttribute("class", "w-100"),
                        string.Empty
                    );
                }

                //classes used to emphasize previous/next month's days
                var mutedClasses = "d-none d-lg-inline-block bg-light text-muted";

                //generate individual date html
                yield return new XElement("div",
                new XAttribute("class", $"day col-lg p-2 border border-left-0 border-top-0 text-wrap {(d.Month != monthStart.Month ? mutedClasses : null)}"),
                new XElement("h6",
                    new XAttribute("class", "row align-items-right"),
                    new XElement("span",
                        new XAttribute("class", "date col-1 ml-2"),
                        d.Day
                    ),
                    new XElement("small",
                        new XAttribute("class", "col d-lg-none text-center text-muted"),
                        d.DayOfWeek.ToString()
                    ),
                    new XElement("span",
                        new XAttribute("class", "col-1"),
                        String.Empty
                    )
                ),

                //get offers html
                GetOfferHtml(d),

                //get requests html
                GetRequestHtml(d)
                );
            }
        }

        //requests button
        IEnumerable<XElement> GetRequestHtml(DateTime d)
        {
            //get all requests from database
            Requests = _db.RiderRequests.Distinct().ToList();

            //IEnumerable of requests that's used to generate corresponding buttons
            IEnumerable<IGrouping<DateTime, RiderRequest>> requests = null;

            foreach (var request in Requests)
            {
                if (request.ToNMC == true && request.ArrivalTime.Date == d.Date)
                {
                    requests = Requests?.GroupBy(r => r.ArrivalTime);
                    return requests?.FirstOrDefault(r => r.Key.Date == d.Date)?.Select(r =>
                       new XElement("a",
                       new XAttribute("class", "btn-warning text-white p-1 rounded d-flex justify-content-center w-75 mx-auto mt-1 mb-30"),
                       new XAttribute("data-toggle", "modal"),
                       new XAttribute("data-target", "#RequestsModal"),
                       new XAttribute("data-date", $"{d.Date}"),
                       "Requests"
                       )
                   );
                }
                else
                {
                    requests = Requests?.GroupBy(r => r.DepartureTime);
                }
            }

            return requests?.FirstOrDefault(r => r.Key.Date == d.Date)?.Select(r =>
                new XElement("a",
                new XAttribute("class", "btn-warning text-white p-1 rounded d-flex justify-content-center w-75 mx-auto mt-1 mb-30"),
                new XAttribute("data-toggle", "modal"),
                new XAttribute("data-target", "#RequestsModal"),
                new XAttribute("data-date", $"{d.Date}"),
                "Requests"
                )
            );
        }

        //offers button
        IEnumerable<XElement> GetOfferHtml(DateTime d)
        {
            //get all offers from database
            Offers = _db.DriverOffers.Distinct().ToList();

            //IEnumerable of offers that's used to gernerate corresponding buttons
            IEnumerable<IGrouping<DateTime, DriverOffer>> offers = null;

            foreach (var offer in Offers)
            {
                if (offer.ToNMC == true && offer.ArrivalTime.Date == d.Date)
                {
                    offers = Offers?.GroupBy(o => o.ArrivalTime);

                    return offers?.FirstOrDefault(o => o.Key.Date == d.Date)?.Select(o =>
                        new XElement("a",
                        new XAttribute("class", "btn-success text-white p-1 rounded d-flex justify-content-center w-75 mx-auto"),
                        new XAttribute("data-toggle", "modal"),
                        new XAttribute("data-target", "#OffersModal"),
                        new XAttribute("data-date", $"{d.Date}"),
                        "Offers"
                        )
                    );
                }
                else
                {
                    offers = Offers?.GroupBy(o => o.DepartureTime);
                }
            }

            return offers?.FirstOrDefault(o => o.Key.Date == d.Date)?.Select(o =>
                new XElement("a",
                new XAttribute("class", "btn-success text-white p-1 rounded d-flex justify-content-center w-75 mx-auto"),
                new XAttribute("data-toggle", "modal"),
                new XAttribute("data-target", "#OffersModal"),
                new XAttribute("data-date", $"{d.Date}"),
                "Offers"
                )
            );
        }

        #endregion
    }
}