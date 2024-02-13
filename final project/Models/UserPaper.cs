using System;
using System.Collections.Generic;

#nullable disable

namespace final_project.Models
{
    public partial class UserPaper
    {
        public int UserId { get; set; }
        public int PaperId { get; set; }

        public virtual Paper Paper { get; set; }
        public virtual User User { get; set; }
    }
}
