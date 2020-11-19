using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsRole
    {
        public UmsRole()
        {
            UmsNotificationAssign = new HashSet<UmsNotificationAssign>();
            UmsReportpermission = new HashSet<UmsReportpermission>();
            UmsRoleassign = new HashSet<UmsRoleassign>();
            UmsRoledtl = new HashSet<UmsRoledtl>();
        }

        public long Roleid { get; set; }
        public string Rolename { get; set; }
        public string Purpose { get; set; }
        public string Recstatus { get; set; }
        public string AppId { get; set; }

        public virtual ICollection<UmsNotificationAssign> UmsNotificationAssign { get; set; }
        public virtual ICollection<UmsReportpermission> UmsReportpermission { get; set; }
        public virtual ICollection<UmsRoleassign> UmsRoleassign { get; set; }
        public virtual ICollection<UmsRoledtl> UmsRoledtl { get; set; }
    }
}
