using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsMenu
    {
        public long Menuid { get; set; }
        public string Menufeatureid { get; set; }
        public long? Parentid { get; set; }
        public string Menuname { get; set; }
        public string Menulocation { get; set; }
        public int? Menusequence { get; set; }
        public string Recstatus { get; set; }

        public virtual UmsFeatureconfig Menufeature { get; set; }
    }
}
