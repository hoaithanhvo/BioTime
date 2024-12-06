using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class PersonnelArea
    {
        public PersonnelArea()
        {
            AccAcccombinations = new HashSet<AccAcccombination>();
            AccAccgroups = new HashSet<AccAccgroup>();
            AccAccholidays = new HashSet<AccAccholiday>();
            AccAccprivileges = new HashSet<AccAccprivilege>();
            AccAcctimezones = new HashSet<AccAcctimezone>();
            AuthUserAuthAreas = new HashSet<AuthUserAuthArea>();
            IclockTerminals = new HashSet<IclockTerminal>();
            InverseParentArea = new HashSet<PersonnelArea>();
            PersonnelAssignareaemployees = new HashSet<PersonnelAssignareaemployee>();
            PersonnelEmployeeAreas = new HashSet<PersonnelEmployeeArea>();
            VisitorVisitorAreas = new HashSet<VisitorVisitorArea>();
        }

        public int Id { get; set; }
        public string AreaCode { get; set; } = null!;
        public string AreaName { get; set; } = null!;
        public bool IsDefault { get; set; }
        public int? ParentAreaId { get; set; }
        public int CompanyId { get; set; }
        public int DeviceCount { get; set; }
        public int EmployeeCount { get; set; }

        public virtual PersonnelCompany Company { get; set; } = null!;
        public virtual PersonnelArea? ParentArea { get; set; }
        public virtual ICollection<AccAcccombination> AccAcccombinations { get; set; }
        public virtual ICollection<AccAccgroup> AccAccgroups { get; set; }
        public virtual ICollection<AccAccholiday> AccAccholidays { get; set; }
        public virtual ICollection<AccAccprivilege> AccAccprivileges { get; set; }
        public virtual ICollection<AccAcctimezone> AccAcctimezones { get; set; }
        public virtual ICollection<AuthUserAuthArea> AuthUserAuthAreas { get; set; }
        public virtual ICollection<IclockTerminal> IclockTerminals { get; set; }
        public virtual ICollection<PersonnelArea> InverseParentArea { get; set; }
        public virtual ICollection<PersonnelAssignareaemployee> PersonnelAssignareaemployees { get; set; }
        public virtual ICollection<PersonnelEmployeeArea> PersonnelEmployeeAreas { get; set; }
        public virtual ICollection<VisitorVisitorArea> VisitorVisitorAreas { get; set; }
    }
}
