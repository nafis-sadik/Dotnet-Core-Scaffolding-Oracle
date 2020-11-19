using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsModuleconfig
    {
        public UmsModuleconfig()
        {
            UmsAuthque = new HashSet<UmsAuthque>();
            UmsFeatureconfig = new HashSet<UmsFeatureconfig>();
            UmsRoledtl = new HashSet<UmsRoledtl>();
            UmsUsersessionlog = new HashSet<UmsUsersessionlog>();
        }

        public long Moduleconfid { get; set; }
        public string Moduleid { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string Appid { get; set; }
        public string Recstatus { get; set; }
        public string Imagepath { get; set; }

        public virtual UmsAppconfig App { get; set; }
        public virtual ICollection<UmsAuthque> UmsAuthque { get; set; }
        public virtual ICollection<UmsFeatureconfig> UmsFeatureconfig { get; set; }
        public virtual ICollection<UmsRoledtl> UmsRoledtl { get; set; }
        public virtual ICollection<UmsUsersessionlog> UmsUsersessionlog { get; set; }
    }
}
