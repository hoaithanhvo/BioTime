﻿using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class IclockBiophoto
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string? ChangeUser { get; set; }
        public short Status { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? EnrollSn { get; set; }
        public string RegisterPhoto { get; set; } = null!;
        public DateTime RegisterTime { get; set; }
        public string? ApprovalPhoto { get; set; }
        public short ApprovalState { get; set; }
        public DateTime? ApprovalTime { get; set; }
        public string? Remark { get; set; }
        public int EmployeeId { get; set; }

        public virtual PersonnelEmployee Employee { get; set; } = null!;
    }
}
