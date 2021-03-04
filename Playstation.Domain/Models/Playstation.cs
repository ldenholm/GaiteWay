using System;
using System.Collections.Generic;
using System.Text;

namespace Playstation.Domain.Models
{
    public class Playstation
    {
        public string ModelName { get; set; }
        public string YearReleased { get; set; }
        public decimal Price { get; set; }
        public bool IsSpecialEdition { get; set; }
    }
}
