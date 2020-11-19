using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsUsersessionlog
    {
        public long Activityid { get; set; }
        public long? Sessionid { get; set; }
        public string Featureid { get; set; }
        public string Actionid { get; set; }
        public string Actionname { get; set; }
        public string Actiontype { get; set; }
        public string Moduleid { get; set; }
        public DateTime? Actiondatetime { get; set; }
        public string Recstatus { get; set; }

        public virtual UmsFeatureconfig Feature { get; set; }
        public virtual UmsModuleconfig Module { get; set; }
        public virtual UmsUsersession Session { get; set; }
    }
}
