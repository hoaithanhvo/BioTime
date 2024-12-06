using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class AttManuallog
    {
        public int WorkflowinstancePtrId { get; set; }
        public DateTime PunchTime { get; set; }
        public string PunchState { get; set; } = null!;
        public int? WorkCodeId { get; set; }
        public string? ApplyReason { get; set; }
        public DateTime ApplyTime { get; set; }
        public string? Attachment { get; set; }

        public virtual IclockTerminalworkcode? WorkCode { get; set; }
        public virtual WorkflowWorkflowinstance WorkflowinstancePtr { get; set; } = null!;
    }
}
