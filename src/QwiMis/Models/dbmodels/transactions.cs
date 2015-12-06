using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QWI.Models.dbmodels
{
    public class transactions
    {
        [Key]
        public Guid transactionid { get; set; }
        public DateTime transactiondate { get; set; }
        public int chartofaccountid { get; set; }
        public decimal? debit { get; set; }
        public decimal? credit { get; set; }
        public int transacttypeid { get; set; }
        public int referencevalue { get; set; }
        public DateTime entrydate { get; set; }

        public virtual ICollection<chartofaccount> chartofaccount { get; set; }

    }
}
