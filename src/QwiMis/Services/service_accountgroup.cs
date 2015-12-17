using QWI.Models.dbmodels;
using QwiMis.repositories;
using System.Data;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System;
using QwiMis.interfaces;
using QwiMis.Models;
using Microsoft.AspNet.Mvc;

namespace QwiMis.Services
{
    public class service_accountgroup:Iaccountgroupservice
    {
        [FromServices]
        public ApplicationDbContext _dbcontext { get; set; }

        private repo_accountgroup accountgrouprepo
        {
            get; set;
        }

        public service_accountgroup( ApplicationDbContext _dbcontext )
        {
            accountgrouprepo = new repo_accountgroup(_dbcontext);
        }

        IEnumerable<accountgroup> Iaccountgroupservice.getallaccountgroups()
        {
           return accountgrouprepo.GetAll();
        }

        private bool add_validation(accountgroup model)
        {
            if (model == null)
            {
                return false;
            }
            else if (accountgrouprepo.recordpresent(m=>m.accountgroupname==model.accountgroupname)){
                return false;

            }
            accountgrouprepo.save(model);
            return true;
        }

        int Iaccountgroupservice.SaveRecord(accountgroup model)
        {
            if (!add_validation(model))
            {
                return 0;
            }
            try { 
            int num = accountgrouprepo.savechanges();
            }
            catch ( Exception dbcx)
            {
                string error = "Dbexception" + dbcx.Message;
            }
            return model.accountgroupid;


        }
    }
}
