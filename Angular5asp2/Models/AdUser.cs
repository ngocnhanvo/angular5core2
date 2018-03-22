using System;
using System.Collections.Generic;

namespace Angular5asp2.Models
{
    public partial class AdUser
    {
        public string AdUserId { get; set; }
        public string AdRoleId { get; set; }
        public string Usercode { get; set; }
        public string Username { get; set; }
        public DateTime? Birthday { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string Marital { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public string BackgroundLayout { get; set; }
        public string Facebook { get; set; }
        public string Skype { get; set; }
        public string Job { get; set; }
        public string Createby { get; set; }
        public string Updateby { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool? Active { get; set; }
    }
}
