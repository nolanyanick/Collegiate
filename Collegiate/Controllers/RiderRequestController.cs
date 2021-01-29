using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Collegiate.Models;
using Collegiate.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Collegiate.Data;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using System.Globalization;

namespace Collegiate.Controllers
{

    public class RiderRequestController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private static ApplicationDbContext _db;
        private static IHttpContextAccessor _httpContextAccessor; //allows you to get current user data.
        public List<Address> _userAddresses;
        RiderRequestToNMCViewModel _vm;


        public RiderRequestController(ILogger<HomeController> logger, ApplicationDbContext db, IHttpContextAccessor httpContextAccessor)
        {
             _logger = logger;
            _db = db;
            _httpContextAccessor = httpContextAccessor;
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _userAddresses = _db.Addresses
                                .Where(u => u.UserId == userId)
                                .ToList();
            _userAddresses.Insert(0, new Address()); //This is just here to leave a space so they can select an item.
            _vm = new RiderRequestToNMCViewModel(_userAddresses);
        }
        
        // GET: RiderRequest
        public ActionResult Index()
        {
            return View("~Views/Ride/R_RideRequest");
        }

        // GET: RiderRequest/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult ToOrFrom()
        {
            return View("ToOrFrom");
        }

        public ActionResult CreateToNMC()
        {
            return View("CreateToNMC", _vm);
        }

        // POST: RiderRequest/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateToNMC(RiderRequestToNMCViewModel data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add insert logic here
                    string userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    string addressID = data.AddressID;

                    RiderRequest newRiderRequest = new RiderRequest();
                    Address addAddress = new Address();
                    addAddress.AddressId = Guid.NewGuid().ToString(); 
                    addAddress.Address1 = data.ManualAddress.Address1;
                    addAddress.Address2 = data.ManualAddress.Address2;
                    addAddress.City = data.ManualAddress.City;
                    addAddress.Zip = data.ManualAddress.Zip;
                    addAddress.LocationName = data.ManualAddress.LocationName;
                    addAddress.Type = data.ManualAddress.Type;
                    addAddress.PickupLocationDescription = data.ManualAddress.PickupLocationDescription ?? "";
                    addAddress.UserId = userId;

                    Address GetOrAddAddress(Address addingAddress, string addressId = "noAddress")
                    {
                        if(addressId == null)
                        {
                            //add address to the database
                            _db.Addresses.Add(addingAddress);
                            _db.SaveChanges();
                            return addingAddress;
                        }
                        else
                        {
                            var existingAddress = _db.Addresses.Where(a => a.AddressId == addressId)
                                                                .FirstOrDefault<Address>();

                            return existingAddress;                
                            //look up existing address and add it to the request
                        }
                    }

                    Address requestAddress = GetOrAddAddress(addAddress, addressID);


                    newRiderRequest.RiderRequestId = Guid.NewGuid().ToString();
                    newRiderRequest.ArrivalTime = DateTime.ParseExact(data.DepartDate + " " + data.DepartTime, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None);
                    newRiderRequest.Address = requestAddress;
                    newRiderRequest.AddressId = requestAddress.AddressId;
                    newRiderRequest.ToNMC = true;
                    newRiderRequest.RiderComments = data.RiderComments;
                    newRiderRequest.OfferClosed = false;
                    newRiderRequest.UserId = userId;
                    _db.RiderRequests.Add(newRiderRequest);
                    _db.SaveChanges();
                    return Redirect("~/Home/FindRide");
                    //return RedirectToAction(nameof(Index));
                }
                catch
                {
                    //This is the dumbest thing but AddressList just will not post back. :<
                    //So instead I'm just rebuilding it for each run.
                    return View("CreateToNMC", _vm);
                }
            } 
            else
            {
                //_vm = GetViewModelReady();
                return View("CreateToNMC", _vm);
            }
            
        }

        public ActionResult CreateFromNMC()
        {
            return View();
        }

        // POST: RiderRequest/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateFromNMC(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RiderRequest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RiderRequest/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RiderRequest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RiderRequest/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}