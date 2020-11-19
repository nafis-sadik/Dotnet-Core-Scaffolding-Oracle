using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsReporting
    {
        public UmsReporting()
        {
            UmsReportpermission = new HashSet<UmsReportpermission>();
        }

        public string Reportingid { get; set; }
        public string Slno { get; set; }
        public string Reportname { get; set; }
        public string Reportpath { get; set; }
        public string Reportaction { get; set; }
        public string Reportlevel { get; set; }
        public string Level1 { get; set; }
        public string Level2 { get; set; }
        public string Level3 { get; set; }
        public string Recstatus { get; set; }
        public string Entrydate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Dataset { get; set; }

        public virtual ICollection<UmsReportpermission> UmsReportpermission { get; set; }
    }
}
