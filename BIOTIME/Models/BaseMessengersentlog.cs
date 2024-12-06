using System;
using System.Collections.Generic;
using System.Net;

namespace BIOTIME.Models
{
    public partial class BaseMessengersentlog
    {
        public long Id { get; set; }
        public short Action { get; set; }
        public string? Targets { get; set; }
        public string? TargetsRepr { get; set; }
        public short ActionStatus { get; set; }
        public string? Description { get; set; }
        public IPAddress? IpAddress { get; set; }
        public bool CanRoutable { get; set; }
        public DateTime OpTime { get; set; }
        public string? BotUid { get; set; }
        public int? ContentTypeId { get; set; }
        public int? EmpId { get; set; }
        public int UserId { get; set; }

        public virtual DjangoContentType? ContentType { get; set; }
        public virtual PersonnelEmployee? Emp { get; set; }
        public virtual AuthUser User { get; set; } = null!;
    }
}
