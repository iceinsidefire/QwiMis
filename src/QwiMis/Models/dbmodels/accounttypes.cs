using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QWI.Models.dbmodels
{
    public class accounttypes
    {

        [Key]
        public int accounttypesid { get; set; }
        public string accounttypename { get; set; }
        public int accountgroupid { get; set; }

        public virtual accountgroup accountgroup { get; set; }
        public virtual ICollection<chartofaccount> chartofaccounts {get;set;}
    }

   
}
