using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class WorkflowWorkflowinstance
    {
        public WorkflowWorkflowinstance()
        {
            WorkflowNodeinstances = new HashSet<WorkflowNodeinstance>();
        }

        public int Id { get; set; }
        public DateTime? ApprovalTime { get; set; }
        public short ApprovalStatus { get; set; }
        public string? ApprovalRemark { get; set; }
        public string? Approver { get; set; }
        public string? ApproverInstance { get; set; }
        public int EmployeeId { get; set; }
        public int? WorkflowEngineId { get; set; }

        public virtual PersonnelEmployee Employee { get; set; } = null!;
        public virtual WorkflowWorkflowengine? WorkflowEngine { get; set; }
        public virtual AttChangeschedule AttChangeschedule { get; set; } = null!;
        public virtual AttLeave AttLeave { get; set; } = null!;
        public virtual AttManuallog AttManuallog { get; set; } = null!;
        public virtual AttOvertime AttOvertime { get; set; } = null!;
        public virtual AttTraining AttTraining { get; set; } = null!;
        public virtual AttWebpunch AttWebpunch { get; set; } = null!;
        public virtual MeetingMeetingentity MeetingMeetingentity { get; set; } = null!;
        public virtual MeetingMeetingmanuallog MeetingMeetingmanuallog { get; set; } = null!;
        public virtual VisitorReservation VisitorReservation { get; set; } = null!;
        public virtual ICollection<WorkflowNodeinstance> WorkflowNodeinstances { get; set; }
    }
}
