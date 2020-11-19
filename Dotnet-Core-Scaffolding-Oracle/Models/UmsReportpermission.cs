using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsReportpermission
    {
        public long Reportpermissionid { get; set; }
        public long Roleid { get; set; }
        public string Reportid { get; set; }
        public string Appid { get; set; }
        public string Recstatus { get; set; }

        public virtual UmsAppconfig App { get; set; }
        public virtual UmsReporting Report { get; set; }
        public virtual UmsRole Role { get; set; }
    }
}
