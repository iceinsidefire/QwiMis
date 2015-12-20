using QWI.Models.dbmodels;
using QwiMis.Models;

namespace QwiMis.repositories
{
    public class repo_products : genericrepository<products>
    {
        public repo_products(ApplicationDbContext context) : base(context)
        {
            _dbcontext = context;
            _dbset = _dbcontext.products;
        }
    }
}
