using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class AttLeavegroup
    {
        public AttLeavegroup()
        {
            AttLeavegroupdetails = new HashSet<AttLeavegroupdetail>();
        }

        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string? ChangeUser { get; set; }
        public short Status { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int CompanyId { get; set; }

        public virtual PersonnelCompany Company { get; set; } = null!;
        public virtual ICollection<AttLeavegroupdetail> AttLeavegroupdetails { get; set; }
    }
}
