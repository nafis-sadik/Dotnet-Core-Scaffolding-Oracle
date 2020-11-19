using System;
using System.Collections.Generic;

namespace Dotnet_Core_Scaffolding_Oracle.Models
{
    public partial class UmsUserinfo
    {
        public UmsUserinfo()
        {
            UmsAuthque = new HashSet<UmsAuthque>();
            UmsAuthquedetail = new HashSet<UmsAuthquedetail>();
            UmsLoginfailuretemp = new HashSet<UmsLoginfailuretemp>();
            UmsNotificationdetail = new HashSet<UmsNotificationdetail>();
            UmsPass = new HashSet<UmsPass>();
            UmsRoleassign = new HashSet<UmsRoleassign>();
            UmsUserfavorite = new HashSet<UmsUserfavorite>();
            UmsUsersession = new HashSet<UmsUsersession>();
        }

        public string Userid { get; set; }
        public string Name { get; set; }
        public long Categoryid { get; set; }
        public string Cellno { get; set; }
        public string Email { get; set; }
        public string Dob { get; set; }
        public string Catidval { get; set; }
        public string Mfa { get; set; }
        public string Macaddress { get; set; }
        public string Ipaddress { get; set; }
        public string Recstatus { get; set; }
        public byte[] Picture { get; set; }
        public byte[] Signature { get; set; }
        public byte[] Thumb { get; set; }

        public virtual UmsCategory Category { get; set; }
        public virtual ICollection<UmsAuthque> UmsAuthque { get; set; }
        public virtual ICollection<UmsAuthquedetail> UmsAuthquedetail { get; set; }
        public virtual ICollection<UmsLoginfailuretemp> UmsLoginfailuretemp { get; set; }
        public virtual ICollection<UmsNotificationdetail> UmsNotificationdetail { get; set; }
        public virtual ICollection<UmsPass> UmsPass { get; set; }
        public virtual ICollection<UmsRoleassign> UmsRoleassign { get; set; }
        public virtual ICollection<UmsUserfavorite> UmsUserfavorite { get; set; }
        public virtual ICollection<UmsUsersession> UmsUsersession { get; set; }
    }
}
