using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QWI.Models.dbmodels
{
    public class coils_wirerod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int coilnumber { get; set; }
        public decimal coilweight { get; set; } 
        

        public virtual products product { get; set; }
        public virtual gatein gatein { get; set; }
        public virtual pricklingdetail pricklingdetail { get; set; }
    }

}
