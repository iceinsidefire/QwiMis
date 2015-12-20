using Microsoft.Extensions.DependencyInjection;
using QWI.Models.dbmodels;
using QwiMis.Models;
using System;
using System.Linq;

namespace WebApplication1.Models.dbmodels
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();

            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }

            if (context.producttype.Any() && context.productcategory.Any())
            {
                return;   // DB has been seeded
            }
            context.producttype.AddRange(
             new producttype{typename = "Raw Material"},
             new producttype { typename = "Semi Finish Wire" },
             new producttype { typename = "Patented Wire" },
             new producttype { typename = "Product" }
                      );

            context.productcategory.AddRange(
          new productcategory { categoryname= "Wire Rod" },
          new productcategory { categoryname = "Wire" },
          new productcategory { categoryname = "Barbed Wire" },
          new productcategory { categoryname = "Spoke" }
                   );
            context.SaveChanges();
        }
    }
}