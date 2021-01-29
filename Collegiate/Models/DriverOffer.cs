
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collegiate.Models
{

    
    public class DriverOffer : IEquatable<DriverOffer>
    {
        public string DriverOfferId { get; set; }

        [ForeignKey("DriverId")]
        public string DriverId { get; set; }
        public Driver Driver { get; set; }

        public DateTime DepartureTime { get; set; }
        
        public DateTime ArrivalTime { get; set; }

        public DateTime ReturnTime { get; set; }

        [ForeignKey("AddressId")]
        public string AddressId { get; set; }

        public Address Address { get; set; }

        [Required]
        public bool ToNMC { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }

        public User User { get; set; }

        public bool OfferClosed { get; set; }

        public string Campus { get; set; }

        public string ToMeetLocationDesc { get; set; }

        public string FromMeetLocationDesc { get; set; }

        public int SeatsAvailable { get; set; }

        public ICollection<Comment> DriverComments { get; set; }

        #region METHODS

        //method to remove duplicate buttons based on DepartureTime
        public bool Equals(DriverOffer other)
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