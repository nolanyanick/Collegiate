using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collegiate.Models
{

    //need to be have a community calandar anda personal calandar

    // NOTE: added a field to the 'Month' property to allow for dynamic setting,
    //       and created a constructor to instantiate _month - Nolan


    [NotMapped]
    public class CalendarVM
    {
        private int _month;

        public User User { get; set; }
        public ICollection<RiderRequest> RiderRequest { get; set; }
        public ICollection<DriverOffer> DriverOffers { get; set; }
        public ICollection<RiderRequest> UserRequests { get; set; }
        public ICollection<DriverOffer> UserOffers { get; set; }
        public ICollection<Address> Locations { get; set; }
        public DateTime CurrentDate { get; set; }
        public int Day
        {
            get
            {
                return DateTime.Now.Day;
            }
            set
            {
                Day = value;
            }
        }

        public int Month
        {
            get
            {
                return _month;
            }
            set
            {
                _month = value;
            }
        }
        public int Year
        {
            get
            {
                return DateTime.Now.Year;
            }
            set
            {
                Year = value;
            }
        }
    }
}