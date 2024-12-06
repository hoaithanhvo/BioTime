using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class WorkflowWorkflownode
    {
        public WorkflowWorkflownode()
        {
            WorkflowNodeinstances = new HashSet<WorkflowNodeinstance>();
            WorkflowWorkflownodeApprovers = new HashSet<WorkflowWorkflownodeApprover>();
            WorkflowWorkflownodeNotifiers = new HashSet<WorkflowWorkflownodeNotifier>();
        }

        public int Id { get; set; }
        public string NodeName { get; set; } = null!;
        public int OrderId { get; set; }
        public bool ApproverByOverall { get; set; }
        public bool NotifyByOverall { get; set; }
        public int? WorkflowEngineId { get; set; }
        public int? FromDay { get; set; }
        public int? ToDay { get; set; }

        public virtual WorkflowWorkflowengine? WorkflowEngine { get; set; }
        public virtual ICollection<WorkflowNodeinstance> WorkflowNodeinstances { get; set; }
        public virtual ICollection<WorkflowWorkflownodeApprover> WorkflowWorkflownodeApprovers { get; set; }
        public virtual ICollection<WorkflowWorkflownodeNotifier> WorkflowWorkflownodeNotifiers { get; set; }
    }
}
