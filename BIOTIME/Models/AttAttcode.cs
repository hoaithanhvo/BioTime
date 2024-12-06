using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class AttAttcode
    {
        public AttAttcode()
        {
            AttPayloadattcodes = new HashSet<AttPayloadattcode>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public short DisplayFormat { get; set; }
        public string Symbol { get; set; } = null!;
        public short RoundOff { get; set; }
        public decimal MinVal { get; set; }
        public bool SymbolOnly { get; set; }
        public short Order { get; set; }
        public string? ColorSetting { get; set; }

        public virtual ICollection<AttPayloadattcode> AttPayloadattcodes { get; set; }
    }
}
