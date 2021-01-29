using System.Collections.Generic;

namespace Collegiate.Models
{

    //need to be have a community calandar anda personal calandar

       
    public class Calandar
    {

        public ICollection<RiderRequest> RiderRequest { get; set; }
        
        public ICollection<DriverOffer> DriverOffers { get; set; }
        
        public ICollection<Trip> Trips { get; set; }
        
        public ICollection<Address> Locations { get; set; }
        
        public ICollection<DriverOffer> UsersOffers { get; set; }

        public ICollection<RiderRequest> UserRequest { get; set; }
    }
}