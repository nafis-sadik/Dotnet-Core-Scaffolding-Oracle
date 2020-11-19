using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsUserfavorite
    {
        public long Id { get; set; }
        public string Userid { get; set; }
        public string Appid { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Urllink { get; set; }
        public string Pagetitle { get; set; }
        public string Recstatus { get; set; }

        public virtual UmsUserinfo User { get; set; }
    }
}
