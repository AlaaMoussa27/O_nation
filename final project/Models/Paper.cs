using System;
using System.Collections.Generic;

#nullable disable

namespace final_project.Models
{
    public partial class Paper
    {
        public Paper()
        {
            CountryPurposePapers = new HashSet<CountryPurposePaper>();
            UserPapers = new HashSet<UserPaper>();
        }

        public int PaperId { get; set; }
        public string PaperName { get; set; }
        public string PaperPlace { get; set; }

        public virtual ICollection<CountryPurposePaper> CountryPurposePapers { get; set; }
        public virtual ICollection<UserPaper> UserPapers { get; set; }
    }
}
