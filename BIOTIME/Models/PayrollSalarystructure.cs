﻿using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class PayrollSalarystructure
    {
        public PayrollSalarystructure()
        {
            PayrollSalarystructureDeductionformulas = new HashSet<PayrollSalarystructureDeductionformula>();
            PayrollSalarystructureExceptionformulas = new HashSet<PayrollSalarystructureExceptionformula>();
            PayrollSalarystructureIncreasementformulas = new HashSet<PayrollSalarystructureIncreasementformula>();
            PayrollSalarystructureLeaveformulas = new HashSet<PayrollSalarystructureLeaveformula>();
            PayrollSalarystructureOvertimeformulas = new HashSet<PayrollSalarystructureOvertimeformula>();
        }

        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string? ChangeUser { get; set; }
        public short Status { get; set; }
        public double SalaryAmount { get; set; }
        public DateOnly EffectiveDate { get; set; }
        public string? SalaryRemark { get; set; }
        public int? EmployeeId { get; set; }

        public virtual PersonnelEmployee? Employee { get; set; }
        public virtual ICollection<PayrollSalarystructureDeductionformula> PayrollSalarystructureDeductionformulas { get; set; }
        public virtual ICollection<PayrollSalarystructureExceptionformula> PayrollSalarystructureExceptionformulas { get; set; }
        public virtual ICollection<PayrollSalarystructureIncreasementformula> PayrollSalarystructureIncreasementformulas { get; set; }
        public virtual ICollection<PayrollSalarystructureLeaveformula> PayrollSalarystructureLeaveformulas { get; set; }
        public virtual ICollection<PayrollSalarystructureOvertimeformula> PayrollSalarystructureOvertimeformulas { get; set; }
    }
}
