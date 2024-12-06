using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class PersonnelCompany
    {
        public PersonnelCompany()
        {
            AttAttgroups = new HashSet<AttAttgroup>();
            AttAttshifts = new HashSet<AttAttshift>();
            AttBreaktimes = new HashSet<AttBreaktime>();
            AttLeavegroups = new HashSet<AttLeavegroup>();
            AttTimeintervals = new HashSet<AttTimeinterval>();
            BaseAutoimporttasks = new HashSet<BaseAutoimporttask>();
            IclockTerminalworkcodes = new HashSet<IclockTerminalworkcode>();
            PersonnelAreas = new HashSet<PersonnelArea>();
            PersonnelDepartments = new HashSet<PersonnelDepartment>();
            PersonnelEmployees = new HashSet<PersonnelEmployee>();
            PersonnelPositions = new HashSet<PersonnelPosition>();
            WorkflowWorkflowengines = new HashSet<WorkflowWorkflowengine>();
            WorkflowWorkflowroles = new HashSet<WorkflowWorkflowrole>();
        }

        public int Id { get; set; }
        public string CompanyCode { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public bool IsDefault { get; set; }
        public string? Address { get; set; }
        public string? Address2 { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string? ChangeUser { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateUser { get; set; }
        public string? Email { get; set; }
        public string? Fax { get; set; }
        public string? Logo { get; set; }
        public short LogoPos { get; set; }
        public short NamePos { get; set; }
        public string? Phone { get; set; }
        public string? PostalCode { get; set; }
        public string? State { get; set; }
        public short Status { get; set; }
        public string? Website { get; set; }

        public virtual ICollection<AttAttgroup> AttAttgroups { get; set; }
        public virtual ICollection<AttAttshift> AttAttshifts { get; set; }
        public virtual ICollection<AttBreaktime> AttBreaktimes { get; set; }
        public virtual ICollection<AttLeavegroup> AttLeavegroups { get; set; }
        public virtual ICollection<AttTimeinterval> AttTimeintervals { get; set; }
        public virtual ICollection<BaseAutoimporttask> BaseAutoimporttasks { get; set; }
        public virtual ICollection<IclockTerminalworkcode> IclockTerminalworkcodes { get; set; }
        public virtual ICollection<PersonnelArea> PersonnelAreas { get; set; }
        public virtual ICollection<PersonnelDepartment> PersonnelDepartments { get; set; }
        public virtual ICollection<PersonnelEmployee> PersonnelEmployees { get; set; }
        public virtual ICollection<PersonnelPosition> PersonnelPositions { get; set; }
        public virtual ICollection<WorkflowWorkflowengine> WorkflowWorkflowengines { get; set; }
        public virtual ICollection<WorkflowWorkflowrole> WorkflowWorkflowroles { get; set; }
    }
}
