using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class AttHoliday
    {
        public AttHoliday()
        {
            AccAccholidays = new HashSet<AccAccholiday>();
        }

        public int Id { get; set; }
        public string Alias { get; set; } = null!;
        public DateOnly StartDate { get; set; }
        public short DurationDay { get; set; }
        public bool EnableOtRule { get; set; }
        public Guid? OtRule { get; set; }
        public int? DepartmentId { get; set; }
        public int? AttGroupId { get; set; }
        public string? ColorSetting { get; set; }
        public DateOnly EndDate { get; set; }

        public virtual AttAttgroup? AttGroup { get; set; }
        public virtual PersonnelDepartment? Department { get; set; }
        public virtual ICollection<AccAccholiday> AccAccholidays { get; set; }
    }
}
