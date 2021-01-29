using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Collegiate.Models;
using Collegiate.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims; //allows you to get current user data

namespace Collegiate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _httpContextAccessor; //allows you to get current user data. 

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _db = db;
            _httpContextAccessor = httpContextAccessor;
        }

        //public IActionResult GetCalandarData()
        //{



        //    return View("FindRide", calandarVM);
        //} 

        public IActionResult GetAllRideRequest()
        {
            var rideRequest = _db.RiderRequests.ToList();

            //need a view to be able to pass this in
            return View(rideRequest);
        }

        public IActionResult GetAllDriverOffers()
        {
            var driverOffers = _db.DriverOffers.ToList();

            return View(driverOffers);
        }

        public IActionResult GetAllTrips()
        {
            var allTrips = _db.Trips.ToList();

            return View(allTrips);
        }



        public IActionResult Index()
        {
            // this gets the id for the user. 
            return View();

        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult DevPage()
        {
            return View();
        }
        [Authorize]
        public IActionResult FindRide(string buttonName)
        {
            //int to track and help update calendar
            var currentMonth = HttpContext.Session.GetInt32("Month");
            if (currentMonth == null)
            {
                HttpContext.Session.SetInt32("Month", DateTime.Now.Month);
                currentMonth = HttpContext.Session.GetInt32("Month").Value;
            }

            //model
            List<RiderRequest> thisUsersRequest = new List<RiderRequest>();
            List<Address> thisUsersLocations = new List<Address>();
            List<DriverOffer> thisUsersOffers = new List<DriverOffer>(); //should check to see if they are a driver first. If so display driver offers if not display sign up to be a driver button.
            List<Trip> thisUsersTrips = new List<Trip>();

            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var rideRequests = _db.RiderRequests.ToList();

            var driverOffers = _db.DriverOffers.ToList();

            var trips = _db.Trips.ToList();

            var locations = _db.Addresses
                                .Where(a => a.UserId == userId)
                                .ToList();

            thisUsersRequest = _db.RiderRequests
                                .Where(r => r.UserId == userId)
                                .ToList();

            thisUsersOffers = _db.DriverOffers
                                .Where(d => d.UserId == userId)
                                .ToList();

            var listOfTrips = _db.Trips
                                .ToList();

            foreach (var trip in listOfTrips)
            {
                List<TripUsers> assessedTripUsers = trip.TripUsers.ToList();
                foreach (var user in assessedTripUsers)
                {
                    if (user.UserId == userId)
                    {
                        thisUsersTrips.Add(trip);
                    }
                }

            }

            CalandarVM calandarVM = new CalandarVM();

            //need to filter the locations based on the userId            
            calandarVM.Locations = locations;
            calandarVM.Trips = trips;
            calandarVM.Locations = locations;
            calandarVM.UserOffers = thisUsersOffers;
            calandarVM.UserRequests = thisUsersRequest;
            calandarVM.UserTrips = thisUsersTrips;

            foreach (var offer in driverOffers)
                offer.Address = _db.Addresses.Where(x => x.AddressId == offer.AddressId).FirstOrDefault() as Address;

            foreach (var request in rideRequests)
                if (request.Address == null)
                    request.Address = _db.Addresses.Where(x => x.AddressId == request.AddressId).FirstOrDefault() as Address;

            calandarVM.DriverOffers = driverOffers;
            calandarVM.RiderRequest = rideRequests;

            //the following code determines if user selected next or previous month,
            //and updates the calendar accordingly
            #region Update Calendar Code

            if (buttonName == "nextMonth")
            {
                //if current month is December (equal to 12),
                //keep it that way
                if (currentMonth < 12)
                {
                    HttpContext.Session.SetInt32("Month", currentMonth.Value + 1);
                    currentMonth++;
                }
                else
                {
                    currentMonth = 12;
                    HttpContext.Session.SetInt32("Month", 12);
                }

                calandarVM.Month = currentMonth.Value;
                return View(calandarVM);
            }
            else if (buttonName == "prevMonth")
            {
                //if current month is Janurary (equal to 1),
                //keep it that way
                if (currentMonth > 1)
                {
                    HttpContext.Session.SetInt32("Month", currentMonth.Value - 1);
                    currentMonth--;
                }
                else
                {
                    currentMonth = 1;
                    HttpContext.Session.SetInt32("Month", 1);
                }

                calandarVM.Month = currentMonth.Value;
                return View(calandarVM);
            }
            else
            {
                calandarVM.Month = currentMonth.Value;
            }

            #endregion

            return View(calandarVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
