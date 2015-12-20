using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QWI.Models.dbmodels
{
    public class productcategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productcategoryid { get; set; }

        public string categoryname { get; set; } //Wire Rod, Wire, Barbed Wire, Spoke, Patented
        

        public virtual chartofaccount chartofaccount { get; set; }
        public virtual ICollection<products> products { get; set; }
        public virtual ICollection<gatein> gatein { get; set; }
    }
}
