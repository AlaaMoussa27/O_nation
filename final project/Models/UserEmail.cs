using System;
using System.Collections.Generic;

#nullable disable

namespace final_project.Models
{
    public partial class UserEmail
    {
        public int UserId { get; set; }
        public string Email { get; set; }

        public virtual User User { get; set; }
    }
}
