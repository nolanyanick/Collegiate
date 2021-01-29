

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collegiate.Models
{
    public class Driver
    {
        public string DriverId { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }

        public User User { get; set; }

        public double DriverRating { get; set; }

        [ForeignKey("VehicleId")]
        public string VehicleId { get; set; }
        public  ICollection<Vehicle> Vehicle { get; set; }

    }
}