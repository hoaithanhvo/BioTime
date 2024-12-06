using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class PersonnelDepartment
    {
        public PersonnelDepartment()
        {
            AttDepartmentpolicies = new HashSet<AttDepartmentpolicy>();
            AttDepartmentschedules = new HashSet<AttDepartmentschedule>();
            AttDeptattrules = new HashSet<AttDeptattrule>();
            AttHolidays = new HashSet<AttHoliday>();
            AuthUserAuthDepts = new HashSet<AuthUserAuthDept>();
            BaseLinenotifysettings = new HashSet<BaseLinenotifysetting>();
            InverseParentDept = new HashSet<PersonnelDepartment>();
            MobileGpsfordepartments = new HashSet<MobileGpsfordepartment>();
            PersonnelEmployees = new HashSet<PersonnelEmployee>();
            VisitorReservations = new HashSet<VisitorReservation>();
            VisitorVisitors = new HashSet<VisitorVisitor>();
            WorkflowWorkflowengines = new HashSet<WorkflowWorkflowengine>();
        }

        public int Id { get; set; }
        public string DeptCode { get; set; } = null!;
        public string DeptName { get; set; } = null!;
        public bool IsDefault { get; set; }
        public int? ParentDeptId { get; set; }
        public int? DeptManagerId { get; set; }
        public int CompanyId { get; set; }

        public virtual PersonnelCompany Company { get; set; } = null!;
        public virtual PersonnelEmployee? DeptManager { get; set; }
        public virtual PersonnelDepartment? ParentDept { get; set; }
        public virtual ICollection<AttDepartmentpolicy> AttDepartmentpolicies { get; set; }
        public virtual ICollection<AttDepartmentschedule> AttDepartmentschedules { get; set; }
        public virtual ICollection<AttDeptattrule> AttDeptattrules { get; set; }
        public virtual ICollection<AttHoliday> AttHolidays { get; set; }
        public virtual ICollection<AuthUserAuthDept> AuthUserAuthDepts { get; set; }
        public virtual ICollection<BaseLinenotifysetting> BaseLinenotifysettings { get; set; }
        public virtual ICollection<PersonnelDepartment> InverseParentDept { get; set; }
        public virtual ICollection<MobileGpsfordepartment> MobileGpsfordepartments { get; set; }
        public virtual ICollection<PersonnelEmployee> PersonnelEmployees { get; set; }
        public virtual ICollection<VisitorReservation> VisitorReservations { get; set; }
        public virtual ICollection<VisitorVisitor> VisitorVisitors { get; set; }
        public virtual ICollection<WorkflowWorkflowengine> WorkflowWorkflowengines { get; set; }
    }
}
