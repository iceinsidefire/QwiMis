using Microsoft.Data.Entity;
using QWI.Models.dbmodels;
using QwiMis.interfaces;
using QwiMis.Models;
using QwiMis.repositories;
using System;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace QwiMis.Services
{
    public class service_gatein :  IGenericSerives<gatein>
    {
        //private ApplicationDbContext _contexts;
        public genericrepository<gatein> _repo_gatein;
        public ApplicationDbContext _context;

        public service_gatein(IServiceProvider serviceProvider)
        {
            _repo_gatein = new genericrepository<gatein>(serviceProvider);
            _context = serviceProvider.GetService<ApplicationDbContext>();


        }

        public async Task<IEnumerable> getallgatein()
        {
        
        
            Task<IEnumerable> t = new Task<IEnumerable>(() =>
            {
                return _context.gatein.Include(p => p.productcategory);
            });
        t.Start();
            return await t;


    }

    public async Task<IEnumerable> getall()
    {

            
        return await _repo_gatein.GetAll();
        //productsrepo.GetAll();
    }

  
    

        public Task<gatein> first(Expression<Func<gatein, bool>> predi)
        {
            return  _repo_gatein.first(predi);
        }

        public Task<gatein> singleasync(Expression<Func<gatein, bool>> predi)
        {
            return _repo_gatein.singleasync(predi);
        }

        public IQueryable<gatein> search(Expression<Func<gatein, bool>> predi)
        {
            return _repo_gatein.search(predi);
        }

        public void add(gatein entity)
        {
            _repo_gatein.add(entity);
        }

        public void add(IEnumerable<gatein> entities)
        {
            _repo_gatein.add(entities);
        }

        public void add_adddependent(gatein entity)
        {
            _repo_gatein.add_adddependent(entity);
        }

        public void add_adddependent(IEnumerable<gatein> entities)
        {
            _repo_gatein.add_adddependent(entities);
        }

        public int count(Expression<Func<gatein, bool>> predi)
        {
            return _repo_gatein.count(predi);
        }

        public void update(gatein entity)
        {
            _repo_gatein.update(entity);
        }

        public void update_range(IEnumerable<gatein> entities)
        {
            _repo_gatein.update_range(entities);
        }

        public void update_adddependent(gatein entity)
        {
            _repo_gatein.add_adddependent(entity);
        }

        public void update_adddependent(IEnumerable<gatein> entities)
        {
            _repo_gatein.add_adddependent(entities);
        }

        public bool recordpresent(Expression<Func<gatein, bool>> predi)
        {
            return _repo_gatein.recordpresent(predi);
        }

        public void remove(gatein entity)
        {
            _repo_gatein.remove(entity);
        }

        public void remove(IEnumerable<gatein> entities)
        {
            _repo_gatein.remove(entities);
        }

        public int savechanges()
        {
            return _repo_gatein.savechanges();
        }

        public Task<int> savechangesasync()
        {
            return _repo_gatein.savechangesasync();
        }
    }
}