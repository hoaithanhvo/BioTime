using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class MeetingMeetingentity
    {
        public MeetingMeetingentity()
        {
            MeetingMeetingentityAttenders = new HashSet<MeetingMeetingentityAttender>();
            MeetingMeetingmanuallogs = new HashSet<MeetingMeetingmanuallog>();
            MeetingMeetingpayloadbases = new HashSet<MeetingMeetingpayloadbase>();
            MeetingMeetingtransactions = new HashSet<MeetingMeetingtransaction>();
        }

        public int WorkflowinstancePtrId { get; set; }
        public string Code { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public string? Content { get; set; }
        public DateOnly MeetingDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Duration { get; set; }
        public bool InRequired { get; set; }
        public DateTime InStart { get; set; }
        public DateTime InEnd { get; set; }
        public bool OutRequired { get; set; }
        public DateTime OutStart { get; set; }
        public DateTime OutEnd { get; set; }
        public string ApplyReason { get; set; } = null!;
        public DateTime ApplyTime { get; set; }
        public DateTime? CalculationTime { get; set; }
        public DateTime? SyncTime { get; set; }
        public int? RoomId { get; set; }
        public string AutoRecording { get; set; } = null!;
        public bool EnableVirtual { get; set; }
        public bool EnableWaitingRoom { get; set; }
        public bool HostVideo { get; set; }
        public bool JbhAnytime { get; set; }
        public string? LinkData { get; set; }
        public bool MuteUponEntry { get; set; }
        public bool ParticipantVideo { get; set; }
        public string? Preferences { get; set; }
        public short TimeZone { get; set; }
        public DateOnly ViewDate { get; set; }
        public string? VirutalUuid { get; set; }

        public virtual MeetingMeetingroom? Room { get; set; }
        public virtual WorkflowWorkflowinstance WorkflowinstancePtr { get; set; } = null!;
        public virtual ICollection<MeetingMeetingentityAttender> MeetingMeetingentityAttenders { get; set; }
        public virtual ICollection<MeetingMeetingmanuallog> MeetingMeetingmanuallogs { get; set; }
        public virtual ICollection<MeetingMeetingpayloadbase> MeetingMeetingpayloadbases { get; set; }
        public virtual ICollection<MeetingMeetingtransaction> MeetingMeetingtransactions { get; set; }
    }
}
