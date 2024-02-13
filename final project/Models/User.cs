using System;
using System.Collections.Generic;

#nullable disable

namespace final_project.Models
{
    public partial class User
    {
        public User()
        {
            UserEmails = new HashSet<UserEmail>();
            UserPapers = new HashSet<UserPaper>();
            UserPhones = new HashSet<UserPhone>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserPhoto { get; set; }
        public int? CountryId { get; set; }
        public int? PurposeId { get; set; }

        public virtual Country Country { get; set; }
        public virtual Purpose Purpose { get; set; }
        public virtual ICollection<UserEmail> UserEmails { get; set; }
        public virtual ICollection<UserPaper> UserPapers { get; set; }
        public virtual ICollection<UserPhone> UserPhones { get; set; }
        public int Id { get; internal set; }
    }
}
