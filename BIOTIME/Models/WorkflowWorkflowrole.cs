using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class WorkflowWorkflowrole
    {
        public WorkflowWorkflowrole()
        {
            InverseParentRole = new HashSet<WorkflowWorkflowrole>();
            PersonnelEmployeeFlowRoles = new HashSet<PersonnelEmployeeFlowRole>();
            WorkflowWorkflownodeApprovers = new HashSet<WorkflowWorkflownodeApprover>();
            WorkflowWorkflownodeNotifiers = new HashSet<WorkflowWorkflownodeNotifier>();
        }

        public int Id { get; set; }
        public string RoleCode { get; set; } = null!;
        public string RoleName { get; set; } = null!;
        public string? Description { get; set; }
        public int CompanyId { get; set; }
        public int? ParentRoleId { get; set; }

        public virtual PersonnelCompany Company { get; set; } = null!;
        public virtual WorkflowWorkflowrole? ParentRole { get; set; }
        public virtual ICollection<WorkflowWorkflowrole> InverseParentRole { get; set; }
        public virtual ICollection<PersonnelEmployeeFlowRole> PersonnelEmployeeFlowRoles { get; set; }
        public virtual ICollection<WorkflowWorkflownodeApprover> WorkflowWorkflownodeApprovers { get; set; }
        public virtual ICollection<WorkflowWorkflownodeNotifier> WorkflowWorkflownodeNotifiers { get; set; }
    }
}
