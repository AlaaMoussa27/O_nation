using System;
using System.Collections.Generic;

#nullable disable

namespace final_project.Models
{
    public partial class CountryImage
    {
        public int CountryId { get; set; }
        public int ImageId { get; set; }
        public string ImageData { get; set; }

        public virtual Country Country { get; set; }
    }
}
