﻿using QWI.Models.dbmodels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwiMis.interfaces
{
    public interface Iproductservice:IServices,IGenericSerives<products>
    {
        Task<IEnumerable> getallproducts_with_type();
    }
}
