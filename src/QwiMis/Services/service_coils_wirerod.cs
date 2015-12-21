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
    public class service_coils_wirerod : Icoils_wirerodservice, IGenericSerives<coils_wirerod>
    {
        //private ApplicationDbContext _contexts;
        public repo_coils_wirerod _repo_accountgroup;
        public ApplicationDbContext _context;

        public service_coils_wirerod(IServiceProvider serviceProvider)
        {
            _repo_accountgroup = new repo_coils_wirerod(serviceProvider);
            _context = serviceProvider.GetService<ApplicationDbContext>();


        }

        public async Task<IEnumerable> getallcoils_withdetails()
        {
        
        
            Task<IEnumerable> t = new Task<IEnumerable>(() =>
            {
                return _context.coils_wirerod.Include(p => p.gatein).Include(p => p.pricklingdetail.prickling);
            });
        t.Start();
            return await t;


    }

    public async Task<IEnumerable> getall()
    {

            
        return await _repo_accountgroup.GetAll();
        //productsrepo.GetAll();
    }

  
    

        public Task<coils_wirerod> first(Expression<Func<coils_wirerod, bool>> predi)
        {
            return  _repo_accountgroup.first(predi);
        }

        public Task<coils_wirerod> singleasync(Expression<Func<coils_wirerod, bool>> predi)
        {
            return _repo_accountgroup.singleasync(predi);
        }

        public IQueryable<coils_wirerod> search(Expression<Func<coils_wirerod, bool>> predi)
        {
            return _repo_accountgroup.search(predi);
        }

        public void add(coils_wirerod entity)
        {
            _repo_accountgroup.add(entity);
        }

        public void add(IEnumerable<coils_wirerod> entities)
        {
            _repo_accountgroup.add(entities);
        }

        public void add_adddependent(coils_wirerod entity)
        {
            _repo_accountgroup.add_adddependent(entity);
        }

        public void add_adddependent(IEnumerable<coils_wirerod> entities)
        {
            _repo_accountgroup.add_adddependent(entities);
        }

        public int count(Expression<Func<coils_wirerod, bool>> predi)
        {
            return _repo_accountgroup.count(predi);
        }

        public void update(coils_wirerod entity)
        {
            _repo_accountgroup.update(entity);
        }

        public void update_range(IEnumerable<coils_wirerod> entities)
        {
            _repo_accountgroup.update_range(entities);
        }

        public void update_adddependent(coils_wirerod entity)
        {
            _repo_accountgroup.add_adddependent(entity);
        }

        public void update_adddependent(IEnumerable<coils_wirerod> entities)
        {
            _repo_accountgroup.add_adddependent(entities);
        }

        public bool recordpresent(Expression<Func<coils_wirerod, bool>> predi)
        {
            return _repo_accountgroup.recordpresent(predi);
        }

        public void remove(coils_wirerod entity)
        {
            _repo_accountgroup.remove(entity);
        }

        public void remove(IEnumerable<coils_wirerod> entities)
        {
            _repo_accountgroup.remove(entities);
        }

        public int savechanges()
        {
            return _repo_accountgroup.savechanges();
        }

        public Task<int> savechangesasync()
        {
            return _repo_accountgroup.savechangesasync();
        }
    }
}