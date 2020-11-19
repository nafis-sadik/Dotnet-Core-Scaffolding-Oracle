using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsCategory
    {
        public UmsCategory()
        {
            UmsUserinfo = new HashSet<UmsUserinfo>();
        }

        public long Categoryid { get; set; }
        public string Categoryname { get; set; }
        public string Recstatus { get; set; }

        public virtual ICollection<UmsUserinfo> UmsUserinfo { get; set; }
    }
}
