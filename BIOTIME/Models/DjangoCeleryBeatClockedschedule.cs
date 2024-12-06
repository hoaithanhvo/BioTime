using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class DjangoCeleryBeatClockedschedule
    {
        public DjangoCeleryBeatClockedschedule()
        {
            DjangoCeleryBeatPeriodictask1s = new HashSet<DjangoCeleryBeatPeriodictask1>();
        }

        public int Id { get; set; }
        public DateTime ClockedTime { get; set; }

        public virtual ICollection<DjangoCeleryBeatPeriodictask1> DjangoCeleryBeatPeriodictask1s { get; set; }
    }
}
