using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class Attparam
    {
        public int Id { get; set; }
        public string Paraname { get; set; } = null!;
        public string? Paratype { get; set; }
        public string? Paravalue { get; set; }
    }
}
