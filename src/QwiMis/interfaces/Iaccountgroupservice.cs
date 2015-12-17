using QWI.Models.dbmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwiMis.interfaces
{
    public interface Iaccountgroupservice:IServices
    {
        IEnumerable<accountgroup> getallaccountgroups();
        
         int SaveRecord(accountgroup model);
    }

   
}
