﻿using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class IclockBiodatum
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string? ChangeUser { get; set; }
        public short Status { get; set; }
        public string BioTmp { get; set; } = null!;
        public int? BioNo { get; set; }
        public int? BioIndex { get; set; }
        public int BioType { get; set; }
        public string MajorVer { get; set; } = null!;
        public string MinorVer { get; set; } = null!;
        public int? BioFormat { get; set; }
        public int Valid { get; set; }
        public int Duress { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string? Sn { get; set; }
        public int EmployeeId { get; set; }

        public virtual PersonnelEmployee Employee { get; set; } = null!;
    }
}
