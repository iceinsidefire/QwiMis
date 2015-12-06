
using QwiMis.interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace QWI.Models.dbmodels
{
    public partial class accountgroup
    {
        [Key]
        public int accountgroupid { get; set; }
        public string accountgroupname { get; set; } //Assest,Liabilities,Capital(Equity)\\

        public virtual ICollection<accounttypes> accounttypes { get; set; }
    }

    public partial class accountgroup:IEntity
    {
        public int id
        {
            get
            {
                return accountgroupid;
            }
        }
    }
}