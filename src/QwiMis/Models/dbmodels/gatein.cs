using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace QWI.Models.dbmodels
{
    public class gatein
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int gateinid { get; set; }
        public DateTime date { get; set; }
        public int weightslipnumber { get; set; }
        public string vehicle_number { get; set; }
        public decimal weight { get; set; }
        public virtual productcategory productcategory { get; set; }
    }
}