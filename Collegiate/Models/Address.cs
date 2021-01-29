
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collegiate.Models
{
    public class Address
    { 
        [Required]
        public string AddressId { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }
        
        [Required]                   
        public string Type { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Zip { get; set; }

        [Required]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [Required]
        public string LocationName { get; set; }

        [Display(Name = "Notes about this location?")]
        public string PickupLocationDescription { get; set; }
    }
}