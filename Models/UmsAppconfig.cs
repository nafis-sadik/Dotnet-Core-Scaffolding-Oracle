using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsAppconfig
    {
        public UmsAppconfig()
        {
            UmsAuthque = new HashSet<UmsAuthque>();
            UmsFeatureconfig = new HashSet<UmsFeatureconfig>();
            UmsModuleconfig = new HashSet<UmsModuleconfig>();
            UmsNotification = new HashSet<UmsNotification>();
            UmsNotificationType = new HashSet<UmsNotificationType>();
            UmsPasspolicy = new HashSet<UmsPasspolicy>();
            UmsReportpermission = new HashSet<UmsReportpermission>();
            UmsRoledtl = new HashSet<UmsRoledtl>();
            UmsUsersession = new HashSet<UmsUsersession>();
        }

        public long Appconfid { get; set; }
        public string Appid { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string Type { get; set; }
        public string Platform { get; set; }
        public string Framework { get; set; }
        public string Recstatus { get; set; }

        public virtual ICollection<UmsAuthque> UmsAuthque { get; set; }
        public virtual ICollection<UmsFeatureconfig> UmsFeatureconfig { get; set; }
        public virtual ICollection<UmsModuleconfig> UmsModuleconfig { get; set; }
        public virtual ICollection<UmsNotification> UmsNotification { get; set; }
        public virtual ICollection<UmsNotificationType> UmsNotificationType { get; set; }
        public virtual ICollection<UmsPasspolicy> UmsPasspolicy { get; set; }
        public virtual ICollection<UmsReportpermission> UmsReportpermission { get; set; }
        public virtual ICollection<UmsRoledtl> UmsRoledtl { get; set; }
        public virtual ICollection<UmsUsersession> UmsUsersession { get; set; }
    }
}
