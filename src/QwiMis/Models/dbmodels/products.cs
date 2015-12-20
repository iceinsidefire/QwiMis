using QWI.Models.dbmodels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QWI.Models.dbmodels
{
    public class products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productid { get; set; }

        public string productname { get; set; } // 82B Wire Rod, 6.5mm 65B Wire Rod, Barbed Wire
        public decimal? size { get; set; }
        [ForeignKey("producttype")]
        public int producttypeid { get; set; }
        [ForeignKey("productcategory")]
        public int productcategoryid { get; set; }
        public virtual chartofaccount chartofaccount { get; set; }
        public virtual producttype producttype {get;set;}
        public virtual productcategory productcategory { get; set; }

    }
}