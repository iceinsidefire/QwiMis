using QWI.Models.dbmodels;
using QwiMis.interfaces;
using QwiMis.Models;
using QwiMis.repositories;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace QwiMis.Services
{
    public class service_accountgroup : repo_accountgroup, Iaccountgroupservice, IGenericSerives<accountgroup>
    {
        public service_accountgroup(ApplicationDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IEnumerable> getall()
        {
            return await GetAll();
            //accountgrouprepo.GetAll();
        }

        private bool add_validation(accountgroup model)
        {
            if (model == null)
            {
                return false;
            }
            else if (recordpresent(m => m.accountgroupname == model.accountgroupname))
            {
                return false;
            }
            add(model);
            return true;
        }

        private int saverecord(accountgroup model)
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
            return model.accountgroupid;
        }
    }
}