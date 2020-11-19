using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsAuthque
    {
        public UmsAuthque()
        {
            UmsAuthquedetail = new HashSet<UmsAuthquedetail>();
        }

        public long Authqueid { get; set; }
        public string Entrydate { get; set; }
        public string Featureid { get; set; }
        public string Appid { get; set; }
        public string Moduleid { get; set; }
        public string Tablename { get; set; }
        public string Pkvalue { get; set; }
        public int Maxauthlevel { get; set; }
        public int Appauthlevel { get; set; }
        public string Userid { get; set; }
        public string Action { get; set; }
        public string Remark { get; set; }
        public string Newrecord { get; set; }
        public string Oldrecord { get; set; }
        public string Oldstatus { get; set; }
        public string Recstatus { get; set; }
        public string Urllink { get; set; }
        public string Isauthcancel { get; set; }

        public virtual UmsAppconfig App { get; set; }
        public virtual UmsFeatureconfig Feature { get; set; }
        public virtual UmsModuleconfig Module { get; set; }
        public virtual UmsUserinfo User { get; set; }
        public virtual ICollection<UmsAuthquedetail> UmsAuthquedetail { get; set; }
    }
}
