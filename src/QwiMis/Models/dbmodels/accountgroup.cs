
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        public int Id
        {
            get
            {
                return accountgroupid;
            }
        }
    }
}