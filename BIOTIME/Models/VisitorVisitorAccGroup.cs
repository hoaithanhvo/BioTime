using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class VisitorVisitorAccGroup
    {
        public int Id { get; set; }
        public int VisitorId { get; set; }
        public int AccgroupsId { get; set; }

        public virtual AccAccgroup Accgroups { get; set; } = null!;
        public virtual VisitorVisitor Visitor { get; set; } = null!;
    }
}
