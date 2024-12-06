using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class AttAttshift
    {
        public AttAttshift()
        {
            AttAttschedules = new HashSet<AttAttschedule>();
            AttDepartmentschedules = new HashSet<AttDepartmentschedule>();
            AttGroupschedules = new HashSet<AttGroupschedule>();
            AttPayloadattcodes = new HashSet<AttPayloadattcode>();
            AttPayloadpaycodes = new HashSet<AttPayloadpaycode>();
            AttShiftdetails = new HashSet<AttShiftdetail>();
        }

        public int Id { get; set; }
        public string Alias { get; set; } = null!;
        public short CycleUnit { get; set; }
        public int ShiftCycle { get; set; }
        public bool WorkWeekend { get; set; }
        public short WeekendType { get; set; }
        public bool WorkDayOff { get; set; }
        public short DayOffType { get; set; }
        public short AutoShift { get; set; }
        public bool EnableOtRule { get; set; }
        public short Frequency { get; set; }
        public Guid? OtRule { get; set; }
        public int CompanyId { get; set; }

        public virtual PersonnelCompany Company { get; set; } = null!;
        public virtual ICollection<AttAttschedule> AttAttschedules { get; set; }
        public virtual ICollection<AttDepartmentschedule> AttDepartmentschedules { get; set; }
        public virtual ICollection<AttGroupschedule> AttGroupschedules { get; set; }
        public virtual ICollection<AttPayloadattcode> AttPayloadattcodes { get; set; }
        public virtual ICollection<AttPayloadpaycode> AttPayloadpaycodes { get; set; }
        public virtual ICollection<AttShiftdetail> AttShiftdetails { get; set; }
    }
}
