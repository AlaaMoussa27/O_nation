using System;
using System.Collections.Generic;

#nullable disable

namespace final_project.Models
{
    public partial class UserPhone
    {
        public int UserId { get; set; }
        public string PhoneNum { get; set; }

        public virtual User User { get; set; }
    }
}
