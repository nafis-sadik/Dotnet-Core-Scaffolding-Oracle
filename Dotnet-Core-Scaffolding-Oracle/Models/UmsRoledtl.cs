using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsRoledtl
    {
        public long Roledtlid { get; set; }
        public long Roleid { get; set; }
        public string Appid { get; set; }
        public string Moduleid { get; set; }
        public string Featureid { get; set; }
        public string Createyn { get; set; }
        public string Edityn { get; set; }
        public string Deleteyn { get; set; }
        public string Viewdetailyn { get; set; }
        public string Authyn { get; set; }
        public string Cancelyn { get; set; }
        public string Recstatus { get; set; }

        public virtual UmsAppconfig App { get; set; }
        public virtual UmsFeatureconfig Feature { get; set; }
        public virtual UmsModuleconfig Module { get; set; }
        public virtual UmsRole Role { get; set; }
    }
}
