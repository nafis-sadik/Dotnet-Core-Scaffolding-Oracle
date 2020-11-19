using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsNotification
    {
        public UmsNotification()
        {
            UmsNotificationAssign = new HashSet<UmsNotificationAssign>();
            UmsNotificationdetail = new HashSet<UmsNotificationdetail>();
        }

        public long Notificationid { get; set; }
        public int NotificationTypeId { get; set; }
        public string Appid { get; set; }
        public string Featureid { get; set; }
        public DateTime Entrydate { get; set; }
        public string Recstatus { get; set; }
        public string NotificationMaker { get; set; }
        public string Messagedesc { get; set; }
        public string Remarks { get; set; }

        public virtual UmsAppconfig App { get; set; }
        public virtual UmsFeatureconfig Feature { get; set; }
        public virtual ICollection<UmsNotificationAssign> UmsNotificationAssign { get; set; }
        public virtual ICollection<UmsNotificationdetail> UmsNotificationdetail { get; set; }
    }
}
