using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsRoleassign
    {
        public long Roleassignid { get; set; }
        public string Userid { get; set; }
        public long Roleid { get; set; }
        public string Recstatus { get; set; }

        public virtual UmsRole Role { get; set; }
        public virtual UmsUserinfo User { get; set; }
    }
}
