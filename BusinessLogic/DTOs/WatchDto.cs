using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class WatchDto
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string img { get; set; }
        public string Brand { get; set; }
        public string Material { get; set; }
        public string Guarantee { get; set; }
        public decimal Price { get; set; }
        public int ClockFaceId { get; set; }
        public string? ClockFace { get; set; }
    }
}
