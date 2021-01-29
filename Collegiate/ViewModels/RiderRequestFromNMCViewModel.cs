using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Collegiate.ViewModels
{
    public enum Campuses    
    {
        Main,
        AeroPark,
        GreatLakesCampus,
        UniversityCenter,
        RodersObservatory,
        MunsonHospital,
    };


    public class RiderRequestFromNMCViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public string RiderRequestId { get; set; }

        [Required]
        [Display(Name = "Departure Time")]
        [RegularExpression(@"\d{2}:\d{2}", ErrorMessage = "Departure time is invalid.")]
        public string DepartTime { get; set; }

        [Required]
        [Display(Name = "Departure Date")]
        [RegularExpression(@"([12]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01]))", ErrorMessage = "Departure date is invalid.")]
        public string DepartDate { get; set; }

        [Required]
        [Display(Name="Campus")]
        public Campuses DepartCampus { get; set; }   //this needs to be passed in as an enum

        [Required]
        [MaxLength(300)]
        [Display(Name = "Rider Comments")]
        public string RiderComments { get; set; }

        [Required]
        [Display(Name = "Destination Address")]
        public string DestinationAddressID { get; set; } //this needs to be presented as a dropdown with all the existing addresses. If one does not exist have a link to create one.
       
    }
}
