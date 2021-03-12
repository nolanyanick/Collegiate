
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collegiate.Models
{
   
    public class RiderRequest : IEquatable<RiderRequest>
    {
        public string RiderRequestId { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime ReturnTime { get; set; }
    
        
        [ForeignKey("Address")]
        public string AddressId { get; set; }

        public Address Address { get; set; } //This has an ID that must be queried from the database to get the details of the address

        public bool ToNMC { get; set; }

        public string RiderComments { get; set; }

        public string Campus { get; set; }

        public bool OfferClosed { get; set; }

        public string UserId { get; set; }


        [ForeignKey("UserId")]
        public User User { get; set; }

        #region METHODS

        //method to remove duplicate buttons based on DepartureTime
        public bool Equals(RiderRequest other)
        {

            //Check whether the compared object is null. 
            if (Object.ReferenceEquals(other, null)) return false;

            //Check whether the compared object references the same data. 
            if (Object.ReferenceEquals(this, other)) return true;

            //Check whether the products' properties are equal. 
            return DepartureTime.Equals(other.DepartureTime);
        }

        // If Equals() returns true for a pair of objects  
        // then GetHashCode() must return the same value for these objects. 
        public override int GetHashCode()
        {

            //Get hash code for the Name field if it is not null. 
            //int hashProductName = Name == null ? 0 : Name.GetHashCode();

            //Get hash code for the Code field. 
            int hashProductCode = DepartureTime.GetHashCode();

            //Calculate the hash code for the product. 
            return hashProductCode;
        }

        #endregion
    }
}