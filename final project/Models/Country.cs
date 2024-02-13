using System;
using System.Collections.Generic;

#nullable disable

namespace final_project.Models
{
    public partial class Country
    {
        public Country()
        {
            CountryGroups = new HashSet<CountryGroup>();
            CountryImages = new HashSet<CountryImage>();
            CountryPurposePapers = new HashSet<CountryPurposePaper>();
            Embassies = new HashSet<Embassy>();
            TouristicPlaces = new HashSet<TouristicPlace>();
            Users = new HashSet<User>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryContinent { get; set; }
        public string CountryNotes { get; set; }

        public virtual ICollection<CountryGroup> CountryGroups { get; set; }
        public virtual ICollection<CountryImage> CountryImages { get; set; }
        public virtual ICollection<CountryPurposePaper> CountryPurposePapers { get; set; }
        public virtual ICollection<Embassy> Embassies { get; set; }
        public virtual ICollection<TouristicPlace> TouristicPlaces { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
