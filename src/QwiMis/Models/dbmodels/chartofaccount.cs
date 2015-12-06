using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QWI.Models.dbmodels
{
    public class chartofaccount

    {
        [Key]
    public int chartofaccountid { get; set; }
        public string chartofaccountname { get; set; }
        public int? masteraccountid { get; set; }
        public decimal openingbalance { get; set; }
        public decimal balance { get; set; }
        
        public int accounttypesid { get; set; }
        public string accounttypename { get; set; } //have to amend whenever accounttypesid change.
        public int accountgroupid { get; set; } //have to amend it whenever accounttype group change.
        public string accountgroupname { get; set; } //as above
        public bool isslave { get; set; }

        public virtual accountgroup accountgroup { get; set; }
        [ForeignKey("accounttypesid")]
        public virtual accounttypes accounttypes { get; set; }
        
        public virtual transactions transactions { get; set; }

    }

}
