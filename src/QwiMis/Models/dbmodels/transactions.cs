using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QWI.Models.dbmodels
{
    public class transactions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid transactionid { get; set; } //generic save method will not work
        public DateTime transactiondate { get; set; }
        [ConcurrencyCheck]
        public int chartofaccountid { get; set; }
        [ConcurrencyCheck]
        public decimal? debit { get; set; }
        [ConcurrencyCheck]
        public decimal? credit { get; set; }
        public int transacttypeid { get; set; }
        [ConcurrencyCheck]
        public int? cvid { get; set; }
        [ConcurrencyCheck]
        public int? dvid { get; set; }
        [ConcurrencyCheck]
        public int? jvid { get; set; }
        public DateTime entrydate { get; set; }
        
        public virtual ICollection<chartofaccount> chartofaccount { get; set; }

    }
}
