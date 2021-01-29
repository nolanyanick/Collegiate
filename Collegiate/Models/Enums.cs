using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Collegiate.Models
{
    public enum Campuses
    {
        Main,
        AeroPark,
        GreatLakesCampus,
        UniversityCenter,
        RodersObservatory,
        MunsonHospital,
    }

    public enum LocationType
    {
        Residence,
        [Display(Name="Public Meeting Location")]
        MeetingPlace, 
        Campus
    }
}
