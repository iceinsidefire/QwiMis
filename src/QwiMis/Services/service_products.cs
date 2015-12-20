using QWI.Models.dbmodels;
using QwiMis.interfaces;
using QwiMis.Models;
using QwiMis.repositories;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace QwiMis.Services
{
    public class service_products : repo_products, Iproductservice, IGenericSerives<products>
    {
        public service_products(ApplicationDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IEnumerable> getall()
        {
            return await GetAll();
            //productsrepo.GetAll();
        }

        private bool add_validation(products model)
        {
            if (model == null)
            {
                return false;
            }
            else if (recordpresent(m => m.productid == model.productid))
            {
                return false;
            }
            add(model);
            return true;
        }

        private int saverecord(products model)
        {
            if (!add_validation(model))
            {
                return 0;
            }
            try
            {
                int num = savechanges();
            }
            catch (Exception dbcx)
            {
                string error = "dbexception" + dbcx.Message;
            }
            return model.productid;
        }
    }
}