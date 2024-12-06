﻿using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class PayrollExceptionformula
    {
        public PayrollExceptionformula()
        {
            PayrollSalarystructureExceptionformulas = new HashSet<PayrollSalarystructureExceptionformula>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Formula { get; set; } = null!;
        public string? Remark { get; set; }
        public int PayCodeId { get; set; }

        public virtual AttPaycode PayCode { get; set; } = null!;
        public virtual ICollection<PayrollSalarystructureExceptionformula> PayrollSalarystructureExceptionformulas { get; set; }
    }
}
