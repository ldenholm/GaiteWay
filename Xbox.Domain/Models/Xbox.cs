using System;
using System.Collections.Generic;
using System.Text;
using Xbox.Domain.Enums;

namespace Xbox.Domain.Models
{
    public class Xbox
    {
        public string ModelName { get; set; }
        public string YearReleased { get; set; }
        public ControllerConfig Config { get; set; }
        public decimal Price { get; set; }
    }
}
