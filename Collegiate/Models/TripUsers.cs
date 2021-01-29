﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Collegiate.Models
{
    public class TripUsers
    {
        public string TripId { get; set; }

        public Trip Trip { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }

        public User User { get; set;  }
    }
}
