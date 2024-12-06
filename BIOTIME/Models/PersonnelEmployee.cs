using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class PersonnelEmployee
    {
        public PersonnelEmployee()
        {
            AccAccprivileges = new HashSet<AccAccprivilege>();
            AttAttschedules = new HashSet<AttAttschedule>();
            AttLeaveyearbalances = new HashSet<AttLeaveyearbalance>();
            AttPayloadattcodes = new HashSet<AttPayloadattcode>();
            AttPayloadbases = new HashSet<AttPayloadbase>();
            AttPayloadeffectpunches = new HashSet<AttPayloadeffectpunch>();
            AttPayloadmulpunchsets = new HashSet<AttPayloadmulpunchset>();
            AttPayloadparings = new HashSet<AttPayloadparing>();
            AttPayloadpaycodes = new HashSet<AttPayloadpaycode>();
            AttPayloadpunches = new HashSet<AttPayloadpunch>();
            AttPayloadtimecards = new HashSet<AttPayloadtimecard>();
            AttReporttemplates = new HashSet<AttReporttemplate>();
            AttTemporaryschedules = new HashSet<AttTemporaryschedule>();
            AttTempschedules = new HashSet<AttTempschedule>();
            BaseMessengersentlogs = new HashSet<BaseMessengersentlog>();
            EpEptransactions = new HashSet<EpEptransaction>();
            IclockBiodata = new HashSet<IclockBiodatum>();
            IclockBiophotos = new HashSet<IclockBiophoto>();
            IclockPrivatemessages = new HashSet<IclockPrivatemessage>();
            IclockTransactions = new HashSet<IclockTransaction>();
            InverseSuperior = new HashSet<PersonnelEmployee>();
            MeetingMeetingentityAttenders = new HashSet<MeetingMeetingentityAttender>();
            MeetingMeetingpayloadbases = new HashSet<MeetingMeetingpayloadbase>();
            MeetingMeetingtransactions = new HashSet<MeetingMeetingtransaction>();
            MobileAnnouncementInitSenders = new HashSet<MobileAnnouncement>();
            MobileAnnouncementReceivers = new HashSet<MobileAnnouncement>();
            MobileAppnotificationInitSenders = new HashSet<MobileAppnotification>();
            MobileAppnotificationReceivers = new HashSet<MobileAppnotification>();
            MobileGpsforemployees = new HashSet<MobileGpsforemployee>();
            MobileMobileapirequestlogs = new HashSet<MobileMobileapirequestlog>();
            PayrollEmploans = new HashSet<PayrollEmploan>();
            PayrollExtradeductions = new HashSet<PayrollExtradeduction>();
            PayrollExtraincreases = new HashSet<PayrollExtraincrease>();
            PayrollPayrollpayloads = new HashSet<PayrollPayrollpayload>();
            PayrollReimbursements = new HashSet<PayrollReimbursement>();
            PayrollSalaryadvances = new HashSet<PayrollSalaryadvance>();
            PayrollSalarystructures = new HashSet<PayrollSalarystructure>();
            PersonnelAssignareaemployees = new HashSet<PersonnelAssignareaemployee>();
            PersonnelDepartments = new HashSet<PersonnelDepartment>();
            PersonnelEmployeeAreas = new HashSet<PersonnelEmployeeArea>();
            PersonnelEmployeeFlowRoles = new HashSet<PersonnelEmployeeFlowRole>();
            PersonnelEmployeecalendars = new HashSet<PersonnelEmployeecalendar>();
            PersonnelEmployeecertifications = new HashSet<PersonnelEmployeecertification>();
            VisitorVisitors = new HashSet<VisitorVisitor>();
            WorkflowNodeinstances = new HashSet<WorkflowNodeinstance>();
            WorkflowWorkflowengineEmployees = new HashSet<WorkflowWorkflowengineEmployee>();
            WorkflowWorkflowinstances = new HashSet<WorkflowWorkflowinstance>();
        }

        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string? ChangeUser { get; set; }
        public short Status { get; set; }
        public string EmpCode { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Nickname { get; set; }
        public string? Passport { get; set; }
        public string? DriverLicenseAutomobile { get; set; }
        public string? DriverLicenseMotorcycle { get; set; }
        public string? Photo { get; set; }
        public string? SelfPassword { get; set; }
        public string? DevicePassword { get; set; }
        public int? DevPrivilege { get; set; }
        public string? CardNo { get; set; }
        public string? AccGroup { get; set; }
        public string? AccTimezone { get; set; }
        public string? Gender { get; set; }
        public DateOnly? Birthday { get; set; }
        public string? Address { get; set; }
        public string? Postcode { get; set; }
        public string? OfficeTel { get; set; }
        public string? ContactTel { get; set; }
        public string? Mobile { get; set; }
        public string? National { get; set; }
        public string? Religion { get; set; }
        public string? Title { get; set; }
        public string? EnrollSn { get; set; }
        public string? Ssn { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateOnly? HireDate { get; set; }
        public int? VerifyMode { get; set; }
        public string? City { get; set; }
        public short? EmpType { get; set; }
        public bool EnablePayroll { get; set; }
        public short? AppStatus { get; set; }
        public short? AppRole { get; set; }
        public string? Email { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool IsActive { get; set; }
        public string? SessionKey { get; set; }
        public string? LoginIp { get; set; }
        public int? DepartmentId { get; set; }
        public int? PositionId { get; set; }
        public int? LeaveGroup { get; set; }
        public long? EmpCodeDigit { get; set; }
        public int? SuperiorId { get; set; }
        public int CompanyId { get; set; }

        public virtual PersonnelCompany Company { get; set; } = null!;
        public virtual PersonnelDepartment? Department { get; set; }
        public virtual PersonnelPosition? Position { get; set; }
        public virtual PersonnelEmployee? Superior { get; set; }
        public virtual AttAttemployee AttAttemployee { get; set; } = null!;
        public virtual PayrollEmppayrollprofile PayrollEmppayrollprofile { get; set; } = null!;
        public virtual PersonnelEmployeeextrainfo PersonnelEmployeeextrainfo { get; set; } = null!;
        public virtual PersonnelEmployeeprofile PersonnelEmployeeprofile { get; set; } = null!;
        public virtual PersonnelEmployment PersonnelEmployment { get; set; } = null!;
        public virtual PersonnelResign PersonnelResign { get; set; } = null!;
        public virtual StaffStafftoken StaffStafftoken { get; set; } = null!;
        public virtual ICollection<AccAccprivilege> AccAccprivileges { get; set; }
        public virtual ICollection<AttAttschedule> AttAttschedules { get; set; }
        public virtual ICollection<AttLeaveyearbalance> AttLeaveyearbalances { get; set; }
        public virtual ICollection<AttPayloadattcode> AttPayloadattcodes { get; set; }
        public virtual ICollection<AttPayloadbase> AttPayloadbases { get; set; }
        public virtual ICollection<AttPayloadeffectpunch> AttPayloadeffectpunches { get; set; }
        public virtual ICollection<AttPayloadmulpunchset> AttPayloadmulpunchsets { get; set; }
        public virtual ICollection<AttPayloadparing> AttPayloadparings { get; set; }
        public virtual ICollection<AttPayloadpaycode> AttPayloadpaycodes { get; set; }
        public virtual ICollection<AttPayloadpunch> AttPayloadpunches { get; set; }
        public virtual ICollection<AttPayloadtimecard> AttPayloadtimecards { get; set; }
        public virtual ICollection<AttReporttemplate> AttReporttemplates { get; set; }
        public virtual ICollection<AttTemporaryschedule> AttTemporaryschedules { get; set; }
        public virtual ICollection<AttTempschedule> AttTempschedules { get; set; }
        public virtual ICollection<BaseMessengersentlog> BaseMessengersentlogs { get; set; }
        public virtual ICollection<EpEptransaction> EpEptransactions { get; set; }
        public virtual ICollection<IclockBiodatum> IclockBiodata { get; set; }
        public virtual ICollection<IclockBiophoto> IclockBiophotos { get; set; }
        public virtual ICollection<IclockPrivatemessage> IclockPrivatemessages { get; set; }
        public virtual ICollection<IclockTransaction> IclockTransactions { get; set; }
        public virtual ICollection<PersonnelEmployee> InverseSuperior { get; set; }
        public virtual ICollection<MeetingMeetingentityAttender> MeetingMeetingentityAttenders { get; set; }
        public virtual ICollection<MeetingMeetingpayloadbase> MeetingMeetingpayloadbases { get; set; }
        public virtual ICollection<MeetingMeetingtransaction> MeetingMeetingtransactions { get; set; }
        public virtual ICollection<MobileAnnouncement> MobileAnnouncementInitSenders { get; set; }
        public virtual ICollection<MobileAnnouncement> MobileAnnouncementReceivers { get; set; }
        public virtual ICollection<MobileAppnotification> MobileAppnotificationInitSenders { get; set; }
        public virtual ICollection<MobileAppnotification> MobileAppnotificationReceivers { get; set; }
        public virtual ICollection<MobileGpsforemployee> MobileGpsforemployees { get; set; }
        public virtual ICollection<MobileMobileapirequestlog> MobileMobileapirequestlogs { get; set; }
        public virtual ICollection<PayrollEmploan> PayrollEmploans { get; set; }
        public virtual ICollection<PayrollExtradeduction> PayrollExtradeductions { get; set; }
        public virtual ICollection<PayrollExtraincrease> PayrollExtraincreases { get; set; }
        public virtual ICollection<PayrollPayrollpayload> PayrollPayrollpayloads { get; set; }
        public virtual ICollection<PayrollReimbursement> PayrollReimbursements { get; set; }
        public virtual ICollection<PayrollSalaryadvance> PayrollSalaryadvances { get; set; }
        public virtual ICollection<PayrollSalarystructure> PayrollSalarystructures { get; set; }
        public virtual ICollection<PersonnelAssignareaemployee> PersonnelAssignareaemployees { get; set; }
        public virtual ICollection<PersonnelDepartment> PersonnelDepartments { get; set; }
        public virtual ICollection<PersonnelEmployeeArea> PersonnelEmployeeAreas { get; set; }
        public virtual ICollection<PersonnelEmployeeFlowRole> PersonnelEmployeeFlowRoles { get; set; }
        public virtual ICollection<PersonnelEmployeecalendar> PersonnelEmployeecalendars { get; set; }
        public virtual ICollection<PersonnelEmployeecertification> PersonnelEmployeecertifications { get; set; }
        public virtual ICollection<VisitorVisitor> VisitorVisitors { get; set; }
        public virtual ICollection<WorkflowNodeinstance> WorkflowNodeinstances { get; set; }
        public virtual ICollection<WorkflowWorkflowengineEmployee> WorkflowWorkflowengineEmployees { get; set; }
        public virtual ICollection<WorkflowWorkflowinstance> WorkflowWorkflowinstances { get; set; }
    }
}
