
using QwiMis.interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QWI.Models.dbmodels
{
    public partial class accountgroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int accountgroupid { get; set; }
        public string accountgroupname { get; set; } //Assest,Liabilities,Capital(Equity)\\
        

        public virtual ICollection<accounttypes> accounttypes { get; set; }
    }
    
}