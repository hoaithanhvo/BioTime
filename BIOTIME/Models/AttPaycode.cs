using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class AttPaycode
    {
        public AttPaycode()
        {
            AttAttpolicies = new HashSet<AttAttpolicy>();
            AttBreaktimeLossCodes = new HashSet<AttBreaktime>();
            AttBreaktimeProfitCodes = new HashSet<AttBreaktime>();
            AttDepartmentpolicies = new HashSet<AttDepartmentpolicy>();
            AttGrouppolicies = new HashSet<AttGrouppolicy>();
            AttLeavegroupdetails = new HashSet<AttLeavegroupdetail>();
            AttLeaves = new HashSet<AttLeave>();
            AttLeaveyearbalances = new HashSet<AttLeaveyearbalance>();
            AttOvertimepolicyOvernightPayCodes = new HashSet<AttOvertimepolicy>();
            AttOvertimepolicyPayCodes = new HashSet<AttOvertimepolicy>();
            AttOvertimes = new HashSet<AttOvertime>();
            AttPayloadparings = new HashSet<AttPayloadparing>();
            AttPayloadpaycodes = new HashSet<AttPayloadpaycode>();
            AttTimeintervals = new HashSet<AttTimeinterval>();
            AttTrainings = new HashSet<AttTraining>();
            PayrollExceptionformulas = new HashSet<PayrollExceptionformula>();
            PayrollLeaveformulas = new HashSet<PayrollLeaveformula>();
            PayrollOvertimeformulas = new HashSet<PayrollOvertimeformula>();
            PayrollPayrollpayloadpaycodes = new HashSet<PayrollPayrollpayloadpaycode>();
            WorkflowWorkflowengines = new HashSet<WorkflowWorkflowengine>();
        }

        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string? ChangeUser { get; set; }
        public short Status { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public short CodeType { get; set; }
        public short? Tag { get; set; }
        public short? FixedCode { get; set; }
        public bool IsWork { get; set; }
        public decimal FixedHours { get; set; }
        public bool IsPaid { get; set; }
        public bool IsBenefit { get; set; }
        public short RoundOff { get; set; }
        public decimal MinVal { get; set; }
        public short DisplayFormat { get; set; }
        public string? Symbol { get; set; }
        public short DisplayOrder { get; set; }
        public string? Desc { get; set; }
        public bool IsDisplay { get; set; }
        public bool IsDefault { get; set; }
        public string? ColorSetting { get; set; }

        public virtual ICollection<AttAttpolicy> AttAttpolicies { get; set; }
        public virtual ICollection<AttBreaktime> AttBreaktimeLossCodes { get; set; }
        public virtual ICollection<AttBreaktime> AttBreaktimeProfitCodes { get; set; }
        public virtual ICollection<AttDepartmentpolicy> AttDepartmentpolicies { get; set; }
        public virtual ICollection<AttGrouppolicy> AttGrouppolicies { get; set; }
        public virtual ICollection<AttLeavegroupdetail> AttLeavegroupdetails { get; set; }
        public virtual ICollection<AttLeave> AttLeaves { get; set; }
        public virtual ICollection<AttLeaveyearbalance> AttLeaveyearbalances { get; set; }
        public virtual ICollection<AttOvertimepolicy> AttOvertimepolicyOvernightPayCodes { get; set; }
        public virtual ICollection<AttOvertimepolicy> AttOvertimepolicyPayCodes { get; set; }
        public virtual ICollection<AttOvertime> AttOvertimes { get; set; }
        public virtual ICollection<AttPayloadparing> AttPayloadparings { get; set; }
        public virtual ICollection<AttPayloadpaycode> AttPayloadpaycodes { get; set; }
        public virtual ICollection<AttTimeinterval> AttTimeintervals { get; set; }
        public virtual ICollection<AttTraining> AttTrainings { get; set; }
        public virtual ICollection<PayrollExceptionformula> PayrollExceptionformulas { get; set; }
        public virtual ICollection<PayrollLeaveformula> PayrollLeaveformulas { get; set; }
        public virtual ICollection<PayrollOvertimeformula> PayrollOvertimeformulas { get; set; }
        public virtual ICollection<PayrollPayrollpayloadpaycode> PayrollPayrollpayloadpaycodes { get; set; }
        public virtual ICollection<WorkflowWorkflowengine> WorkflowWorkflowengines { get; set; }
    }
}
