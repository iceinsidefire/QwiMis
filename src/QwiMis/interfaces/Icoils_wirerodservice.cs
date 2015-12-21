using QWI.Models.dbmodels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwiMis.interfaces
{
    public interface Icoils_wirerodservice:IServices,IGenericSerives<coils_wirerod>
    {
        Task<IEnumerable> getallcoils_withdetails();
    }
}
