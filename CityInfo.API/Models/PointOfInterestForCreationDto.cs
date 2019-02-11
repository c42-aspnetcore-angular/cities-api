﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class PointOfInterestForCreationDto
    {
        [Required(ErrorMessage = "You should provide a name value")]
        [MaxLength(25)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }
    }
}
