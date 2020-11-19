using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsNotificationAssign
    {
        public decimal NotificationAssignId { get; set; }
        public int NotificationTypeId { get; set; }
        public long RoleId { get; set; }
        public string Recstatus { get; set; }
        public long? BranchId { get; set; }
        public long? NotificationId { get; set; }
        public string InvestigationUserId { get; set; }
        public long? UserTypeId { get; set; }

        public virtual UmsNotification Notification { get; set; }
        public virtual UmsNotificationType NotificationType { get; set; }
        public virtual UmsRole Role { get; set; }
    }
}
