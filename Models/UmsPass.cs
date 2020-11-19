using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsPass
    {
        public long Passid { get; set; }
        public string Userid { get; set; }
        public string Userpass { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime Expiredate { get; set; }
        public string Recstatus { get; set; }

        public virtual UmsUserinfo User { get; set; }
    }
}
