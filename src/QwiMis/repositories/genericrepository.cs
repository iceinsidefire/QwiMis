using System;
using System.Linq;
using System.Collections.Generic;
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
        public ApplicationDbContext _dbcontext { get; set; }
            
        public DbSet<T> _dbset;

        public genericrepository(ApplicationDbContext context)
        {
            this._dbcontext = context;
            
        }

        public async Task<T> first(Expression<Func<T, bool>> predi)
        {
            T model = await _dbset.FirstOrDefaultAsync(predi);
            
            return model;

        }

         public IQueryable<T> GetAll()
        {
            return _dbset.AsQueryable();
        }

        public IQueryable<T> search(Expression<Func<T, bool>> predi)
        {
            return _dbset.Where(predi);
        }

        public void save(T entity)
        {
            _dbset.Add(entity);
        }

        public void save(IEnumerable<T> entities)
        {
            
                _dbset.AddRange(entities);
            
        }

        public void save_adddependent(T entity)
        {
            _dbset.Add(entity,GraphBehavior.IncludeDependents);
        }

        public void save_adddependent(IEnumerable<T> entities)
        {
            
                _dbset.AddRange(entities,GraphBehavior.IncludeDependents);
            
        }

        public int count (Expression<Func<T, bool>> predi)
        {
            return _dbset.Count (predi);
        }

        public void update(T entity)
        {
            _dbset.Update(entity);
        }

        public void update_range(IEnumerable<T> entities)
        {

            _dbset.UpdateRange(entities);

        }

        public void update_adddependent(T entity)
        {
            _dbset.Update(entity, GraphBehavior.IncludeDependents);
        }

        public void update_adddependent(IEnumerable<T> entities)
        {

            _dbset.UpdateRange(entities, GraphBehavior.IncludeDependents);

        }

        public bool recordpresent(Expression<Func<T, bool>> predi)
        {
          return  _dbset.Any(predi);
        }

        public void remove(T entity)
        {
            _dbset.Remove(entity);
        }

        public void remove(IEnumerable<T> entities)
        {

            _dbset.RemoveRange(entities);

        }

      public int savechanges()
        {
            int num=_dbcontext.SaveChanges();
            return num;
        }

        public async Task<int> savechangesasync()
        {
            int num=await _dbcontext.SaveChangesAsync();
            return num;
        }
        
    }
}
