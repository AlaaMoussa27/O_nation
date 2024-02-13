using System;
using System.Collections.Generic;

#nullable disable

namespace final_project.Models
{
    public partial class CountryGroup
    {
        public int CountryId { get; set; }
        public string CountryGroup1 { get; set; }

        public virtual Country Country { get; set; }
    }
}
