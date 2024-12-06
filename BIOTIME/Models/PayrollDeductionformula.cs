using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class PayrollDeductionformula
    {
        public PayrollDeductionformula()
        {
            PayrollSalarystructureDeductionformulas = new HashSet<PayrollSalarystructureDeductionformula>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Formula { get; set; } = null!;
        public string? Remark { get; set; }

        public virtual ICollection<PayrollSalarystructureDeductionformula> PayrollSalarystructureDeductionformulas { get; set; }
    }
}
