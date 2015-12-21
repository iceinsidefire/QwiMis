using QWI.Models.dbmodels;
using QwiMis.Models;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace QwiMis.repositories
{
    public class repo_products : genericrepository<products>
    {
        public repo_products(IServiceProvider serviceProvider) : base(serviceProvider)
        {
           
        }
    }
}
