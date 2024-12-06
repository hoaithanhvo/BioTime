using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class VisitorVisitor
    {
        public VisitorVisitor()
        {
            VisitorVisitorAccGroups = new HashSet<VisitorVisitorAccGroup>();
            VisitorVisitorAreas = new HashSet<VisitorVisitorArea>();
            VisitorVisitorbiodata = new HashSet<VisitorVisitorbiodatum>();
            VisitorVisitorbiophotos = new HashSet<VisitorVisitorbiophoto>();
            VisitorVisitorlogs = new HashSet<VisitorVisitorlog>();
            VisitorVisitortransactions = new HashSet<VisitorVisitortransaction>();
        }

        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string? ChangeUser { get; set; }
        public short Status { get; set; }
        public string VisitorCode { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string CertNo { get; set; } = null!;
        public string? Photo { get; set; }
        public string? Password { get; set; }
        public string? CardNo { get; set; }
        public string? Gender { get; set; }
        public string? Company { get; set; }
        public string? Ssn { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public int VisitQuantity { get; set; }
        public string? EntryCarryingGoods { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public string? ExitCarryingGoods { get; set; }
        public string? Remark { get; set; }
        public int CertTypeId { get; set; }
        public int? VisitDepartmentId { get; set; }
        public int? VisitReasonId { get; set; }
        public int VisitedId { get; set; }

        public virtual PersonnelCertification CertType { get; set; } = null!;
        public virtual PersonnelDepartment? VisitDepartment { get; set; }
        public virtual VisitorReason? VisitReason { get; set; }
        public virtual PersonnelEmployee Visited { get; set; } = null!;
        public virtual ICollection<VisitorVisitorAccGroup> VisitorVisitorAccGroups { get; set; }
        public virtual ICollection<VisitorVisitorArea> VisitorVisitorAreas { get; set; }
        public virtual ICollection<VisitorVisitorbiodatum> VisitorVisitorbiodata { get; set; }
        public virtual ICollection<VisitorVisitorbiophoto> VisitorVisitorbiophotos { get; set; }
        public virtual ICollection<VisitorVisitorlog> VisitorVisitorlogs { get; set; }
        public virtual ICollection<VisitorVisitortransaction> VisitorVisitortransactions { get; set; }
    }
}
