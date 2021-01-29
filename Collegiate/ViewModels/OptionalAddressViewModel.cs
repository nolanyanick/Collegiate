using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ExpressiveAnnotations.Attributes;
using Collegiate.Models;
using ExpressiveAnnotations.MvcUnobtrusive.Validators;

namespace Collegiate.ViewModels
{
    public class OptionalAddressViewModel
    {
        public RiderRequestToNMCViewModel Parent { get; set; }

        public string AddressId { get; set; }

        public string UserId { get; set; }
        public string Type { get; set; }
        public string City { get; set; }

        [RequiredIf("Parent.AddressID == null", AllowEmptyStrings = false, ErrorMessage = "Zip is required.")]
        [RegularExpression(@"^[0-9]{5}(-[0-9]{4})?$", ErrorMessage = "Zip code isn't formatted correctly.")]
        public string Zip { get; set; }

        [RequiredIf("Parent.AddressID == null", AllowEmptyStrings = false, ErrorMessage = "Address is required.")]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [RequiredIf("Parent.AddressID == null", AllowEmptyStrings = false, ErrorMessage = "Location name is required.")]
        public string LocationName { get; set; }

        public string PickupLocationDescription { get; set; }
    }
}
