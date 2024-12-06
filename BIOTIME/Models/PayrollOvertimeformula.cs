using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class PayrollOvertimeformula
    {
        public PayrollOvertimeformula()
        {
            PayrollSalarystructureOvertimeformulas = new HashSet<PayrollSalarystructureOvertimeformula>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Formula { get; set; } = null!;
        public string? Remark { get; set; }
        public int PayCodeId { get; set; }

        public virtual AttPaycode PayCode { get; set; } = null!;
        public virtual ICollection<PayrollSalarystructureOvertimeformula> PayrollSalarystructureOvertimeformulas { get; set; }
    }
}
