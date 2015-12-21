using QWI.Models.dbmodels;
using QwiMis.Models;
using System;
using Microsoft.Extensions.DependencyInjection;


namespace QwiMis.repositories
{
    public class repo_coils_wirerod : genericrepository<coils_wirerod>
    {
        public repo_coils_wirerod(IServiceProvider serviceProvider) : base(serviceProvider)
        {
                
               // _dbcontext = serviceProvider.GetService<ApplicationDbContext>();
          //  _dbset = _dbcontext.coils_wirerod;
        }
    }
}
