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
    public class service_products :  Iproductservice, IGenericSerives<products>
    {
        private readonly repo_products _repo_product;
        private readonly ApplicationDbContext _context;
        public service_products(IServiceProvider serviceProvider)
        {
            _repo_product = new repo_products(serviceProvider);
            _context = serviceProvider.GetService<ApplicationDbContext>();

        }
        public async Task<IEnumerable> getallproducts_with_type()
        {
            Task<IEnumerable> t = new Task<IEnumerable>(() =>
            {
                return _context.products.Include(p => p.productcategory).Include(p => p.producttype);
            });
            t.Start();
            return await t;

            
        }


        public async Task<IEnumerable> getall()
        {
            return await _repo_product.GetAll();
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

        

        




        public Task<products> first(Expression<Func<products, bool>> predi)
        {
            return _repo_product.first(predi);
        }

        public Task<products> singleasync(Expression<Func<products, bool>> predi)
        {
            return _repo_product.singleasync(predi);
        }

        public IQueryable<products> search(Expression<Func<products, bool>> predi)
        {
            return _repo_product.search(predi);
        }

        public void add(products entity)
        {
            _repo_product.add(entity);
        }

        public void add(IEnumerable<products> entities)
        {
            _repo_product.add(entities);
        }

        public void add_adddependent(products entity)
        {
            _repo_product.add_adddependent(entity);
 
        }

        public void add_adddependent(IEnumerable<products> entities)
        {
            _repo_product.add_adddependent(entities);
        }

        public int count(Expression<Func<products, bool>> predi)
        {
            return _repo_product.count(predi);
        }

        public void update(products entity)
        {
            _repo_product.update(entity);
        }

        public void update_range(IEnumerable<products> entities)
        {
            _repo_product.update_range(entities);
        }

        public void update_adddependent(products entity)
        {
            _repo_product.add_adddependent(entity);
        }

        public void update_adddependent(IEnumerable<products> entities)
        {
            _repo_product.add_adddependent(entities);
        }

        public bool recordpresent(Expression<Func<products, bool>> predi)
        {
            return _repo_product.recordpresent(predi);
        }

        public void remove(products entity)
        {
            _repo_product.remove(entity);
        }

        public void remove(IEnumerable<products> entities)
        {
            _repo_product.remove(entities);
        }

        public int savechanges()
        {
            return _repo_product.savechanges();
        }

        public Task<int> savechangesasync()
        {
            return _repo_product.savechangesasync();
        }
    }
}

