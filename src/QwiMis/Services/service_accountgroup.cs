using QWI.Models.dbmodels;
using QwiMis.interfaces;
using QwiMis.Models;
using QwiMis.repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QwiMis.Services
{
    public class service_accountgroup : Iaccountgroupservice, IGenericSerives<accountgroup>
    {
        private repo_accountgroup _repo_accountgroup;
        public service_accountgroup(IServiceProvider serviceProvider)
        {
            _repo_accountgroup = new repo_accountgroup(serviceProvider);
        }

        public async Task<IEnumerable> getall()
        {


            return await _repo_accountgroup.GetAll();
            //productsrepo.GetAll();
        }




        public Task<accountgroup> first(Expression<Func<accountgroup, bool>> predi)
        {
            return _repo_accountgroup.first(predi);
        }

        public Task<accountgroup> singleasync(Expression<Func<accountgroup, bool>> predi)
        {
            return _repo_accountgroup.singleasync(predi);
        }

        public IQueryable<accountgroup> search(Expression<Func<accountgroup, bool>> predi)
        {
            return _repo_accountgroup.search(predi);
        }

        public void add(accountgroup entity)
        {
            _repo_accountgroup.add(entity);
        }

        public void add(IEnumerable<accountgroup> entities)
        {
            _repo_accountgroup.add(entities);
        }

        public void add_adddependent(accountgroup entity)
        {
            _repo_accountgroup.add_adddependent(entity);
        }

        public void add_adddependent(IEnumerable<accountgroup> entities)
        {
            _repo_accountgroup.add_adddependent(entities);
        }

        public int count(Expression<Func<accountgroup, bool>> predi)
        {
            return _repo_accountgroup.count(predi);
        }

        public void update(accountgroup entity)
        {
            _repo_accountgroup.update(entity);
        }

        public void update_range(IEnumerable<accountgroup> entities)
        {
            _repo_accountgroup.update_range(entities);
        }

        public void update_adddependent(accountgroup entity)
        {
            _repo_accountgroup.add_adddependent(entity);
        }

        public void update_adddependent(IEnumerable<accountgroup> entities)
        {
            _repo_accountgroup.add_adddependent(entities);
        }

        public bool recordpresent(Expression<Func<accountgroup, bool>> predi)
        {
            return _repo_accountgroup.recordpresent(predi);
        }

        public void remove(accountgroup entity)
        {
            _repo_accountgroup.remove(entity);
        }

        public void remove(IEnumerable<accountgroup> entities)
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