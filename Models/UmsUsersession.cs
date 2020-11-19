using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsUsersession
    {
        public UmsUsersession()
        {
            UmsUsersessionlog = new HashSet<UmsUsersessionlog>();
        }

        public long Sessionid { get; set; }
        public string Userid { get; set; }
        public string Appid { get; set; }
        public DateTime? Logindatetime { get; set; }
        public string Ipaddress { get; set; }
        public DateTime? Logoutdatetime { get; set; }
        public string Recstatus { get; set; }

        public virtual UmsAppconfig App { get; set; }
        public virtual UmsUserinfo User { get; set; }
        public virtual ICollection<UmsUsersessionlog> UmsUsersessionlog { get; set; }
    }
}
