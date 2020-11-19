using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsReportparameter
    {
        public long Reportparameterid { get; set; }
        public string Featureid { get; set; }
        public string Datatype { get; set; }
        public string Levelname { get; set; }
        public string Parametername { get; set; }
        public string Recstatus { get; set; }

        public virtual UmsFeatureconfig Feature { get; set; }
    }
}
