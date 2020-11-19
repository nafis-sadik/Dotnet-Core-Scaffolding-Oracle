using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsNotificationdetail
    {
        public long Id { get; set; }
        public string Userid { get; set; }
        public long Notificationid { get; set; }

        public virtual UmsNotification Notification { get; set; }
        public virtual UmsUserinfo User { get; set; }
    }
}
