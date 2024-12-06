using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class IclockTransaction
    {
        public IclockTransaction()
        {
            AttPayloadeffectpunches = new HashSet<AttPayloadeffectpunch>();
            AttPayloadparingInTrans = new HashSet<AttPayloadparing>();
            AttPayloadparingOutTrans = new HashSet<AttPayloadparing>();
            AttPayloadpunches = new HashSet<AttPayloadpunch>();
        }

        public int Id { get; set; }
        public string EmpCode { get; set; } = null!;
        public DateTime PunchTime { get; set; }
        public string PunchState { get; set; } = null!;
        public int VerifyType { get; set; }
        public string? WorkCode { get; set; }
        public string? TerminalSn { get; set; }
        public string? TerminalAlias { get; set; }
        public string? AreaAlias { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string? GpsLocation { get; set; }
        public string? Mobile { get; set; }
        public short? Source { get; set; }
        public short? Purpose { get; set; }
        public string? Crc { get; set; }
        public short? IsAttendance { get; set; }
        public string? Reserved { get; set; }
        public DateTime? UploadTime { get; set; }
        public short? SyncStatus { get; set; }
        public DateTime? SyncTime { get; set; }
        public short? IsMask { get; set; }
        public decimal? Temperature { get; set; }
        public int? EmpId { get; set; }
        public int? TerminalId { get; set; }
        public string? CompanyCode { get; set; }

        public virtual PersonnelEmployee? Emp { get; set; }
        public virtual IclockTerminal? Terminal { get; set; }
        public virtual ICollection<AttPayloadeffectpunch> AttPayloadeffectpunches { get; set; }
        public virtual ICollection<AttPayloadparing> AttPayloadparingInTrans { get; set; }
        public virtual ICollection<AttPayloadparing> AttPayloadparingOutTrans { get; set; }
        public virtual ICollection<AttPayloadpunch> AttPayloadpunches { get; set; }
    }
}
