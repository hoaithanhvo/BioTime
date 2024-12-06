using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class PersonnelCertification
    {
        public PersonnelCertification()
        {
            PersonnelEmployeecertifications = new HashSet<PersonnelEmployeecertification>();
            VisitorReservations = new HashSet<VisitorReservation>();
            VisitorVisitors = new HashSet<VisitorVisitor>();
        }

        public int Id { get; set; }
        public string CertCode { get; set; } = null!;
        public string CertName { get; set; } = null!;

        public virtual ICollection<PersonnelEmployeecertification> PersonnelEmployeecertifications { get; set; }
        public virtual ICollection<VisitorReservation> VisitorReservations { get; set; }
        public virtual ICollection<VisitorVisitor> VisitorVisitors { get; set; }
    }
}
