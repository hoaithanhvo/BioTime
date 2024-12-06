using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class DjangoCeleryBeatIntervalschedule
    {
        public DjangoCeleryBeatIntervalschedule()
        {
            DjangoCeleryBeatPeriodictask1s = new HashSet<DjangoCeleryBeatPeriodictask1>();
        }

        public int Id { get; set; }
        public int Every { get; set; }
        public string Period { get; set; } = null!;

        public virtual ICollection<DjangoCeleryBeatPeriodictask1> DjangoCeleryBeatPeriodictask1s { get; set; }
    }
}
