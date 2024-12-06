using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class PersonnelPosition
    {
        public PersonnelPosition()
        {
            InverseParentPosition = new HashSet<PersonnelPosition>();
            PersonnelEmployees = new HashSet<PersonnelEmployee>();
            WorkflowWorkflowengines = new HashSet<WorkflowWorkflowengine>();
        }

        public int Id { get; set; }
        public string PositionCode { get; set; } = null!;
        public string PositionName { get; set; } = null!;
        public bool IsDefault { get; set; }
        public int? ParentPositionId { get; set; }
        public int CompanyId { get; set; }

        public virtual PersonnelCompany Company { get; set; } = null!;
        public virtual PersonnelPosition? ParentPosition { get; set; }
        public virtual ICollection<PersonnelPosition> InverseParentPosition { get; set; }
        public virtual ICollection<PersonnelEmployee> PersonnelEmployees { get; set; }
        public virtual ICollection<WorkflowWorkflowengine> WorkflowWorkflowengines { get; set; }
    }
}
