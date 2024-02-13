using System;
using System.Collections.Generic;

#nullable disable

namespace final_project.Models
{
    public partial class TouristicPlace
    {
        public int CountryId { get; set; }
        public string PlaceName { get; set; }

        public virtual Country Country { get; set; }
    }
}
