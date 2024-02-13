using System;
using System.Collections.Generic;

#nullable disable

namespace final_project.Models
{
    public partial class Embassy
    {
        public int EmbassiesId { get; set; }
        public string EmbassiesName { get; set; }
        public string EmbassiesLocation { get; set; }
        public string EmbassiesPhone { get; set; }
        public string EmbassiesFax { get; set; }
        public string EmbassiesMail { get; set; }
        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
