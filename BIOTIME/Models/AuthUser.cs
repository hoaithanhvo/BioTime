using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class AuthUser
    {
        public AuthUser()
        {
            AccountsAdminbiodata = new HashSet<AccountsAdminbiodatum>();
            AccountsUsernotifications = new HashSet<AccountsUsernotification>();
            AttReporttemplates = new HashSet<AttReporttemplate>();
            AuthUserAuthAreas = new HashSet<AuthUserAuthArea>();
            AuthUserAuthDepts = new HashSet<AuthUserAuthDept>();
            AuthUserGroups = new HashSet<AuthUserGroup>();
            AuthUserUserPermissions = new HashSet<AuthUserUserPermission>();
            BaseAdminlogs = new HashSet<BaseAdminlog>();
            BaseBookmarks = new HashSet<BaseBookmark>();
            BaseMessengersentlogs = new HashSet<BaseMessengersentlog>();
            DjangoAdminLogs = new HashSet<DjangoAdminLog>();
            GuardianUserobjectpermissions = new HashSet<GuardianUserobjectpermission>();
            MobileAnnouncements = new HashSet<MobileAnnouncement>();
            MobileAppnotifications = new HashSet<MobileAppnotification>();
            RestFrameworkTrackingApirequestlogs = new HashSet<RestFrameworkTrackingApirequestlog>();
        }

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime? UpdateTime { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? EmpPin { get; set; }
        public string Email { get; set; } = null!;
        public string? TelePhone { get; set; }
        public int? AuthTimeDept { get; set; }
        public int? LoginId { get; set; }
        public int? LoginType { get; set; }
        public int? LoginCount { get; set; }
        public bool IsStaff { get; set; }
        public bool IsActive { get; set; }
        public bool IsSuperuser { get; set; }
        public bool IsPublic { get; set; }
        public bool CanManageAllDept { get; set; }
        public int? DelFlag { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime? LastLogin { get; set; }
        public string? SessionKey { get; set; }
        public string? LoginIp { get; set; }
        public string? Photo { get; set; }
        public int? AssignCompany { get; set; }

        public virtual AuthUserProfile AuthUserProfile { get; set; } = null!;
        public virtual AuthtokenToken AuthtokenToken { get; set; } = null!;
        public virtual ICollection<AccountsAdminbiodatum> AccountsAdminbiodata { get; set; }
        public virtual ICollection<AccountsUsernotification> AccountsUsernotifications { get; set; }
        public virtual ICollection<AttReporttemplate> AttReporttemplates { get; set; }
        public virtual ICollection<AuthUserAuthArea> AuthUserAuthAreas { get; set; }
        public virtual ICollection<AuthUserAuthDept> AuthUserAuthDepts { get; set; }
        public virtual ICollection<AuthUserGroup> AuthUserGroups { get; set; }
        public virtual ICollection<AuthUserUserPermission> AuthUserUserPermissions { get; set; }
        public virtual ICollection<BaseAdminlog> BaseAdminlogs { get; set; }
        public virtual ICollection<BaseBookmark> BaseBookmarks { get; set; }
        public virtual ICollection<BaseMessengersentlog> BaseMessengersentlogs { get; set; }
        public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; set; }
        public virtual ICollection<GuardianUserobjectpermission> GuardianUserobjectpermissions { get; set; }
        public virtual ICollection<MobileAnnouncement> MobileAnnouncements { get; set; }
        public virtual ICollection<MobileAppnotification> MobileAppnotifications { get; set; }
        public virtual ICollection<RestFrameworkTrackingApirequestlog> RestFrameworkTrackingApirequestlogs { get; set; }
    }
}
