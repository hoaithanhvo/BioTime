using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class MeetingMeetingroom
    {
        public MeetingMeetingroom()
        {
            MeetingMeetingentities = new HashSet<MeetingMeetingentity>();
            MeetingMeetingroomdevices = new HashSet<MeetingMeetingroomdevice>();
        }

        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string? ChangeUser { get; set; }
        public short Status { get; set; }
        public string Code { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public int Capacity { get; set; }
        public string Location { get; set; } = null!;
        public string? Remark { get; set; }
        public short State { get; set; }
        public bool EnableRoom { get; set; }

        public virtual ICollection<MeetingMeetingentity> MeetingMeetingentities { get; set; }
        public virtual ICollection<MeetingMeetingroomdevice> MeetingMeetingroomdevices { get; set; }
    }
}
