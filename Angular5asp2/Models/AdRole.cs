using System;
using System.Collections.Generic;

namespace Angular5asp2.Models
{
    public partial class AdRole
    {
        public string AdRoleId { get; set; }
        public string Rolecode { get; set; }
        public string Rolename { get; set; }
        public string Createby { get; set; }
        public string Updateby { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool? Active { get; set; }
    }
}
