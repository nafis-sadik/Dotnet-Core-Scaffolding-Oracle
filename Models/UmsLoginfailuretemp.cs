using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsLoginfailuretemp
    {
        public long Id { get; set; }
        public string Userid { get; set; }
        public string Ipaddress { get; set; }
        public DateTime Logindatetime { get; set; }

        public virtual UmsUserinfo User { get; set; }
    }
}
