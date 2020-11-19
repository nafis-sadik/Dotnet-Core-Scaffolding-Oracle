using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsAuthquedetail
    {
        public long Authquedtlid { get; set; }
        public long Authqueid { get; set; }
        public string Authaction { get; set; }
        public string Userid { get; set; }
        public string Actiondate { get; set; }
        public string Remark { get; set; }
        public string Recstatus { get; set; }

        public virtual UmsAuthque Authque { get; set; }
        public virtual UmsUserinfo User { get; set; }
    }
}
