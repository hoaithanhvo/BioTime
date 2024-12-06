using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class MobileGpsfordepartment
    {
        public MobileGpsfordepartment()
        {
            MobileGpsfordepartmentLocations = new HashSet<MobileGpsfordepartmentLocation>();
        }

        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string? ChangeUser { get; set; }
        public short Status { get; set; }
        public int Distance { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int DepartmentId { get; set; }

        public virtual PersonnelDepartment Department { get; set; } = null!;
        public virtual ICollection<MobileGpsfordepartmentLocation> MobileGpsfordepartmentLocations { get; set; }
    }
}
