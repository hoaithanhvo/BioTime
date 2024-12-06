using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class WorkflowWorkflowengine
    {
        public WorkflowWorkflowengine()
        {
            WorkflowWorkflowengineEmployees = new HashSet<WorkflowWorkflowengineEmployee>();
            WorkflowWorkflowinstances = new HashSet<WorkflowWorkflowinstance>();
            WorkflowWorkflownodes = new HashSet<WorkflowWorkflownode>();
        }

        public int Id { get; set; }
        public string WorkflowCode { get; set; } = null!;
        public string WorkflowName { get; set; } = null!;
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string Description { get; set; } = null!;
        public short WorkflowType { get; set; }
        public int? ApplicantPositionId { get; set; }
        public int? ContentTypeId { get; set; }
        public int? DepartmentsId { get; set; }
        public bool IsLeave { get; set; }
        public int? LeaveTypeId { get; set; }
        public int CompanyId { get; set; }

        public virtual PersonnelPosition? ApplicantPosition { get; set; }
        public virtual PersonnelCompany Company { get; set; } = null!;
        public virtual DjangoContentType? ContentType { get; set; }
        public virtual PersonnelDepartment? Departments { get; set; }
        public virtual AttPaycode? LeaveType { get; set; }
        public virtual ICollection<WorkflowWorkflowengineEmployee> WorkflowWorkflowengineEmployees { get; set; }
        public virtual ICollection<WorkflowWorkflowinstance> WorkflowWorkflowinstances { get; set; }
        public virtual ICollection<WorkflowWorkflownode> WorkflowWorkflownodes { get; set; }
    }
}
