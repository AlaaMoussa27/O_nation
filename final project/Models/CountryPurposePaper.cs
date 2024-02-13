using System;
using System.Collections.Generic;

#nullable disable

namespace final_project.Models
{
    public partial class CountryPurposePaper
    {
        public int CountryId { get; set; }
        public int PaperId { get; set; }
        public int PurposeId { get; set; }
        public string Details { get; set; }

        public virtual Country Country { get; set; }
        public virtual Paper Paper { get; set; }
        public virtual Purpose Purpose { get; set; }
    }
}
