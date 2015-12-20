using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QWI.Models.dbmodels
{
    public class accounttypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int accounttypesid { get; set; }

        public string accounttypename { get; set; }

        [ConcurrencyCheck]
        public int accountgroupid { get; set; }

        public virtual accountgroup accountgroup { get; set; }
        public virtual ICollection<chartofaccount> chartofaccounts { get; set; }
    }
}