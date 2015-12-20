using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QWI.Models.dbmodels
{
    public class pricklingdetail
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid pricklingdetailid { get; set; }
        public int coilnumber { get; set; }

        public virtual coils_wirerod coils_wirerod { get; set; }
        public virtual prickling prickling { get; set; }
    }
}