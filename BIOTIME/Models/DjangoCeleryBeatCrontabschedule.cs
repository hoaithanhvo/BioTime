using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class DjangoCeleryBeatCrontabschedule
    {
        public DjangoCeleryBeatCrontabschedule()
        {
            DjangoCeleryBeatPeriodictask1s = new HashSet<DjangoCeleryBeatPeriodictask1>();
        }

        public int Id { get; set; }
        public string Minute { get; set; } = null!;
        public string Hour { get; set; } = null!;
        public string DayOfWeek { get; set; } = null!;
        public string DayOfMonth { get; set; } = null!;
        public string MonthOfYear { get; set; } = null!;
        public string Timezone { get; set; } = null!;

        public virtual ICollection<DjangoCeleryBeatPeriodictask1> DjangoCeleryBeatPeriodictask1s { get; set; }
    }
}
