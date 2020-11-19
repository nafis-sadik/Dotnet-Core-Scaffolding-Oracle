using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsNotificationType
    {
        public UmsNotificationType()
        {
            UmsNotificationAssign = new HashSet<UmsNotificationAssign>();
        }

        public int NotificationTypeId { get; set; }
        public string AppId { get; set; }
        public string TypeName { get; set; }
        public string Recstatus { get; set; }

        public virtual UmsAppconfig App { get; set; }
        public virtual ICollection<UmsNotificationAssign> UmsNotificationAssign { get; set; }
    }
}
