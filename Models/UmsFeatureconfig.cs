using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsFeatureconfig
    {
        public UmsFeatureconfig()
        {
            UmsAuthque = new HashSet<UmsAuthque>();
            UmsMenu = new HashSet<UmsMenu>();
            UmsNotification = new HashSet<UmsNotification>();
            UmsReportparameter = new HashSet<UmsReportparameter>();
            UmsRoledtl = new HashSet<UmsRoledtl>();
            UmsUsersessionlog = new HashSet<UmsUsersessionlog>();
        }

        public long Featureconfid { get; set; }
        public string Featureid { get; set; }
        public int? Featuretype { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string Appid { get; set; }
        public string Moduleid { get; set; }
        public string Authyn { get; set; }
        public int? Authlevel { get; set; }
        public string Otp { get; set; }
        public string Mfa { get; set; }
        public string Reportpath { get; set; }
        public string Reportaction { get; set; }
        public string Dataset { get; set; }
        public string Recstatus { get; set; }
        public string Createyn { get; set; }
        public string Edityn { get; set; }
        public string Viewdetailyn { get; set; }
        public string Cancelyn { get; set; }

        public virtual UmsAppconfig App { get; set; }
        public virtual UmsModuleconfig Module { get; set; }
        public virtual ICollection<UmsAuthque> UmsAuthque { get; set; }
        public virtual ICollection<UmsMenu> UmsMenu { get; set; }
        public virtual ICollection<UmsNotification> UmsNotification { get; set; }
        public virtual ICollection<UmsReportparameter> UmsReportparameter { get; set; }
        public virtual ICollection<UmsRoledtl> UmsRoledtl { get; set; }
        public virtual ICollection<UmsUsersessionlog> UmsUsersessionlog { get; set; }
    }
}
