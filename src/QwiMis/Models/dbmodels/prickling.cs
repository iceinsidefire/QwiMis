using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QWI.Models.dbmodels
{
    public class prickling
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid pricklingid { get; set; }
        public DateTime date { get; set;}

    }
}