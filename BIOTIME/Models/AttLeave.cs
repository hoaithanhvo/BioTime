using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class AttLeave
    {
        public AttLeave()
        {
            AttPayloadexceptions = new HashSet<AttPayloadexception>();
        }

        public int WorkflowinstancePtrId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? ApplyReason { get; set; }
        public DateTime ApplyTime { get; set; }
        public string? Attachment { get; set; }
        public int? PayCodeId { get; set; }
        public double LeaveDay { get; set; }

        public virtual AttPaycode? PayCode { get; set; }
        public virtual WorkflowWorkflowinstance WorkflowinstancePtr { get; set; } = null!;
        public virtual ICollection<AttPayloadexception> AttPayloadexceptions { get; set; }
    }
}
