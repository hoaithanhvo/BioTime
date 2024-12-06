using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class AttAttreportsetting
    {
        public int Id { get; set; }
        public short ResignEmp { get; set; }
        public short ShortDate { get; set; }
        public short ShortTime { get; set; }
        public bool FilterByHireDate { get; set; }
        public bool AutoCalculate { get; set; }
    }
}
