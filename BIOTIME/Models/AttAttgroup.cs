using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class AttAttgroup
    {
        public AttAttgroup()
        {
            AttAttemployees = new HashSet<AttAttemployee>();
            AttGrouppolicies = new HashSet<AttGrouppolicy>();
            AttGroupschedules = new HashSet<AttGroupschedule>();
            AttHolidays = new HashSet<AttHoliday>();
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
        public virtual ICollection<AttAttemployee> AttAttemployees { get; set; }
        public virtual ICollection<AttGrouppolicy> AttGrouppolicies { get; set; }
        public virtual ICollection<AttGroupschedule> AttGroupschedules { get; set; }
        public virtual ICollection<AttHoliday> AttHolidays { get; set; }
    }
}
