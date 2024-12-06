using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class VisitorReason
    {
        public VisitorReason()
        {
            VisitorReservations = new HashSet<VisitorReservation>();
            VisitorVisitors = new HashSet<VisitorVisitor>();
        }

        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string? ChangeUser { get; set; }
        public short Status { get; set; }
        public string? VisitReason { get; set; }

        public virtual ICollection<VisitorReservation> VisitorReservations { get; set; }
        public virtual ICollection<VisitorVisitor> VisitorVisitors { get; set; }
    }
}
