using System;
using System.Collections.Generic;

namespace BIOTIME.Models
{
    public partial class DjangoContentType
    {
        public DjangoContentType()
        {
            AuthPermissions = new HashSet<AuthPermission>();
            BaseAdminlogs = new HashSet<BaseAdminlog>();
            BaseBookmarks = new HashSet<BaseBookmark>();
            BaseMessengersentlogs = new HashSet<BaseMessengersentlog>();
            DjangoAdminLogs = new HashSet<DjangoAdminLog>();
            GuardianGroupobjectpermissions = new HashSet<GuardianGroupobjectpermission>();
            GuardianUserobjectpermissions = new HashSet<GuardianUserobjectpermission>();
            WorkflowWorkflowengines = new HashSet<WorkflowWorkflowengine>();
        }

        public int Id { get; set; }
        public string AppLabel { get; set; } = null!;
        public string Model { get; set; } = null!;

        public virtual ICollection<AuthPermission> AuthPermissions { get; set; }
        public virtual ICollection<BaseAdminlog> BaseAdminlogs { get; set; }
        public virtual ICollection<BaseBookmark> BaseBookmarks { get; set; }
        public virtual ICollection<BaseMessengersentlog> BaseMessengersentlogs { get; set; }
        public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; set; }
        public virtual ICollection<GuardianGroupobjectpermission> GuardianGroupobjectpermissions { get; set; }
        public virtual ICollection<GuardianUserobjectpermission> GuardianUserobjectpermissions { get; set; }
        public virtual ICollection<WorkflowWorkflowengine> WorkflowWorkflowengines { get; set; }
    }
}
