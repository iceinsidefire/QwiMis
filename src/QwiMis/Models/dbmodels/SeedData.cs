using QwiMis.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QWI.Models.dbmodels;

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

            if (context.accountgroup.Any())
            {
                return;   // DB has been seeded
            }
            context.accountgroup.AddRange(
             new accountgroup
             {
                 accountgroupname = "When Harry Met Sally"

             },

             new accountgroup
             {
                 accountgroupname = "When "
             },

             new accountgroup
             {
                 accountgroupname = "Sally"
             }
             );
            context.SaveChanges();
        }
        }
}
