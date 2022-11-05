﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ClockFace
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Watch> Watches { get; set; }
    }
}
