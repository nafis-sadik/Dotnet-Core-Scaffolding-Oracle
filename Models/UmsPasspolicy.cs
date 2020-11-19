using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsPasspolicy
    {
        public long Passpolicyid { get; set; }
        public string Appid { get; set; }
        public byte Minlength { get; set; }
        public byte Maxlength { get; set; }
        public int Expireafter { get; set; }
        public int Reuse { get; set; }
        public string Isuppercase { get; set; }
        public string Islowercase { get; set; }
        public string Isspecialchar { get; set; }
        public string Recstatus { get; set; }

        public virtual UmsAppconfig App { get; set; }
    }
}
