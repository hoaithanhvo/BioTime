﻿using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class PersonnelEmployeeprofile
    {
        public int Id { get; set; }
        public string ColumnOrder { get; set; } = null!;
        public string Preferences { get; set; } = null!;
        public DateTime? PwdUpdateTime { get; set; }
        public int EmpId { get; set; }
        public string DisabledFields { get; set; } = null!;

        public virtual PersonnelEmployee Emp { get; set; } = null!;
    }
}
