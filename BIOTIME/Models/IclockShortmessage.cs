using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class IclockShortmessage
    {
        public IclockShortmessage()
        {
            IclockPrivatemessages = new HashSet<IclockPrivatemessage>();
            IclockPublicmessages = new HashSet<IclockPublicmessage>();
        }

        public int Id { get; set; }
        public string Message { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public string MsgType { get; set; } = null!;

        public virtual ICollection<IclockPrivatemessage> IclockPrivatemessages { get; set; }
        public virtual ICollection<IclockPublicmessage> IclockPublicmessages { get; set; }
    }
}
