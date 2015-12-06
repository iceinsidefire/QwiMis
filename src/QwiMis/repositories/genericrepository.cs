﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc;
using QwiMis.Models;
using System.Linq.Expressions;

namespace QwiMis.repositories
{
    public class genericrepository<T> where T : class, new()
    {
        [FromServices]
        private ApplicationDbContext _dbcontext { get; set; }

        private DbSet<T> _dbset;
        public genericrepository()
        {
            this._dbset = _dbcontext.Set<T>();
        }

        public async Task<T> first(Expression<Func<T, bool>> predi)
        {
            T model = await _dbset.FirstOrDefaultAsync(predi);

            return model;

        }

        public async Task<bool> Iqueryable<T> All()
        {
            bool x = await _dbset.ToListAsync(default);

            return model;

        }



    }
}
