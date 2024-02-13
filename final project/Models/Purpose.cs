using System;
using System.Collections.Generic;

#nullable disable

namespace final_project.Models
{
    public partial class Purpose
    {
        public Purpose()
        {
            CountryPurposePapers = new HashSet<CountryPurposePaper>();
            Users = new HashSet<User>();
        }

        public int PurposeId { get; set; }
        public string PurposeName { get; set; }
        public string PurposeType { get; set; }

        public virtual ICollection<CountryPurposePaper> CountryPurposePapers { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
