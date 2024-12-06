﻿using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class AccAccgroup
    {
        public AccAccgroup()
        {
            AccAccprivileges = new HashSet<AccAccprivilege>();
            VisitorVisitorAccGroups = new HashSet<VisitorVisitorAccGroup>();
        }

        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string? ChangeUser { get; set; }
        public short Status { get; set; }
        public int GroupNo { get; set; }
        public string GroupName { get; set; } = null!;
        public int VerifyMode { get; set; }
        public int? Timezone1 { get; set; }
        public int? Timezone2 { get; set; }
        public int? Timezone3 { get; set; }
        public short IsIncludeHoliday { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int AreaId { get; set; }

        public virtual PersonnelArea Area { get; set; } = null!;
        public virtual ICollection<AccAccprivilege> AccAccprivileges { get; set; }
        public virtual ICollection<VisitorVisitorAccGroup> VisitorVisitorAccGroups { get; set; }
    }
}
