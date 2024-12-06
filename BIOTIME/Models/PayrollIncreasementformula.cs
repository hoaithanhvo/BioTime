using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class PayrollIncreasementformula
    {
        public PayrollIncreasementformula()
        {
            PayrollSalarystructureIncreasementformulas = new HashSet<PayrollSalarystructureIncreasementformula>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Formula { get; set; } = null!;
        public string? Remark { get; set; }

        public virtual ICollection<PayrollSalarystructureIncreasementformula> PayrollSalarystructureIncreasementformulas { get; set; }
    }
}
