using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Collegiate.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Collegiate.Data;
using System.Security.Claims;

namespace Collegiate.ViewModels
{
    public class RiderRequestToNMCViewModel
    {
        private List<Address> addressList;

        [HiddenInput(DisplayValue = false)]
        public string RiderRequestId { get; set; }

        [Required]
        [RegularExpression(@"\d{2}:\d{2}", ErrorMessage = "Departure time is invalid.")]
        [Display(Name = "Departure Time")]
        public string DepartTime { get; set; }

        [Required]
        [Display(Name = "Departure Date")]
        [RegularExpression(@"([12]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01]))", ErrorMessage = "Departure date is invalid.")]
        public string DepartDate { get; set; }

        [Required]
        [Display(Name = "Campus")]
        public string ArriveCampus { get; set; }   //this needs to be passed in as an enum


        [MaxLength(300)]
        [Display(Name = "Anything potential drivers should know?")]
        public string RiderComments { get; set; }


        [Display(Name = "Pickup Address")]
        public string AddressID { get; set; } //this needs to be presented as a dropdown with all the existing addresses.


        [Display(Name = "Do you need a return trip?")]
        public bool NeedReturnTrip { get; set; }


        public OptionalAddressViewModel ManualAddress { get; set; }

        public RiderRequestToNMCViewModel()
        {
            this.ManualAddress = new OptionalAddressViewModel { Parent = this };
        }

        public RiderRequestToNMCViewModel(List<Address> list)
        {
            this.ManualAddress = new OptionalAddressViewModel { Parent = this };
            this.AddressList = list;
        }

        public RiderRequestToNMCViewModel Clone()
        {
            return this.MemberwiseClone() as RiderRequestToNMCViewModel;
        }

        public List<SelectListItem> MinList
        {
            get
            {
                List<SelectListItem> min = new List<SelectListItem>();
                min.Add(new SelectListItem { Text = "", Value = "", Selected = true });
                min.Add(new SelectListItem { Text = "00", Value = "00" });
                min.Add(new SelectListItem { Text = "15", Value = "15" });
                min.Add(new SelectListItem { Text = "30", Value = "30" });
                min.Add(new SelectListItem { Text = "45", Value = "45" });
                return min;

            }
            set
            {
                MinList = value;
            }
        }


        public List<SelectListItem> MonthList
        {
            get
            {
                List<SelectListItem> month = new List<SelectListItem>();
                month.Add(new SelectListItem { Text = "", Value = "", Selected = true });
                month.Add(new SelectListItem { Text = "Jan", Value = "1" });
                month.Add(new SelectListItem { Text = "Feb", Value = "2" });
                month.Add(new SelectListItem { Text = "Mar", Value = "3" });
                month.Add(new SelectListItem { Text = "Apr", Value = "4" });
                month.Add(new SelectListItem { Text = "May", Value = "5" });
                month.Add(new SelectListItem { Text = "June", Value = "6" });
                month.Add(new SelectListItem { Text = "July", Value = "7" });
                month.Add(new SelectListItem { Text = "Aug", Value = "8" });
                month.Add(new SelectListItem { Text = "Sept", Value = "9" });
                month.Add(new SelectListItem { Text = "Oct", Value = "10" });
                month.Add(new SelectListItem { Text = "Nov", Value = "11" });
                month.Add(new SelectListItem { Text = "Dec", Value = "12" });
                return month;
            }
            set
            {
                MonthList = value;
            }
        }


        public List<SelectListItem> DayList
        {
            get
            {
                List<SelectListItem> dayList = new List<SelectListItem>();
                dayList.Add(new SelectListItem { Text = "", Value = "", Selected = true });

                //need to check on this dynamically to see if the month has 30 or 31 days in it and display the correct day in this section. 
                for (var i = 1; i <= 31; i++)
                {
                    dayList.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
                }

                return dayList;
            }


            set
            {
                DayList = value;
            }
        }

        public List<SelectListItem> YearList
        {
            get
            {
                List<SelectListItem> year = new List<SelectListItem>();
                int getCurrentYear = DateTime.Now.Year;
                int aYearAhead = getCurrentYear + 1;
                year.Add(new SelectListItem { Text = "", Value = "", Selected = true });
                year.Add(new SelectListItem { Text = getCurrentYear.ToString(), Value = getCurrentYear.ToString() });
                year.Add(new SelectListItem { Text = aYearAhead.ToString(), Value = aYearAhead.ToString() });
                return year;
            }

            set
            {
                YearList = value;
            }

        }
        public List<SelectListItem> HourList
        {
            get
            {

                List<SelectListItem> timeList = new List<SelectListItem>();
                timeList.Add(new SelectListItem { Text = "", Value = "", Selected = true });
                timeList.Add(new SelectListItem { Text = "1", Value = "1" });
                timeList.Add(new SelectListItem { Text = "2", Value = "2" });
                timeList.Add(new SelectListItem { Text = "3", Value = "3" });
                timeList.Add(new SelectListItem { Text = "4", Value = "4" });
                timeList.Add(new SelectListItem { Text = "5", Value = "5" });
                timeList.Add(new SelectListItem { Text = "6", Value = "6" });
                timeList.Add(new SelectListItem { Text = "7", Value = "7" });
                timeList.Add(new SelectListItem { Text = "8", Value = "8" });
                timeList.Add(new SelectListItem { Text = "9", Value = "9" });
                timeList.Add(new SelectListItem { Text = "10", Value = "10" });
                timeList.Add(new SelectListItem { Text = "11", Value = "11" });
                timeList.Add(new SelectListItem { Text = "12", Value = "12" });
                return timeList;
            }

            set { HourList = value; }
        }

        public List<SelectListItem> MornList
        {
            get
            {
                List<SelectListItem> morn = new List<SelectListItem>();
                morn.Add(new SelectListItem { Text = "", Value = "", Selected = true });
                morn.Add(new SelectListItem { Text = "AM", Value = "AM" });
                morn.Add(new SelectListItem { Text = "PM", Value = "PM" });
                return morn;
            }
            set
            {
                MornList = value;
            }
        }
        public List<SelectListItem> CampusList
        {
            get
            {
                List<SelectListItem> campusList = new List<SelectListItem>();
                campusList.Add(new SelectListItem { Text = "", Value = "", Selected = true });
                campusList.Add(new SelectListItem { Text = "Main Campus", Value = "Main" });
                campusList.Add(new SelectListItem { Text = "Aero Park", Value = "AeroPark" });
                campusList.Add(new SelectListItem { Text = "Great Lakes", Value = "GreatLakesCampus" });
                campusList.Add(new SelectListItem { Text = "University Center", Value = "UniversityCenter" });
                campusList.Add(new SelectListItem { Text = "Roders Observatory", Value = "RodersObservatory" });
                campusList.Add(new SelectListItem { Text = "Munson Hospital", Value = "MunsonHospital" });
                return campusList;
            }
            set
            {
                CampusList = value;
            }
        }

        public List<Address> AddressList {
            get => addressList;
            set => addressList = value;
        }

        public List<SelectListItem> LocationTypeList
        {
            get
            {
                var locationType = new List<SelectListItem>();

                locationType.Add(new SelectListItem { Text = "", Value = "", Selected = true });

                foreach (LocationType type in (LocationType[])Enum.GetValues(typeof(LocationType)))
                {
                    locationType.Add(new SelectListItem { Text = type.ToString(), Value = type.ToString() });
                }

                return locationType;
            }
            set
            {
                LocationTypeList = value;
            }
        }


    }
}
