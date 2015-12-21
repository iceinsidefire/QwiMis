using Microsoft.Data.Entity;
using QwiMis.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace QwiMis.repositories
{
    public class genericrepository<T> where T : class, new()
    {
        public  ApplicationDbContext _context;
        
        public DbSet<T> _dbset;

        public genericrepository(IServiceProvider serviceProvider)
        {
           _context = serviceProvider.GetService<ApplicationDbContext>();
            this._dbset = _context.Set<T>();
        }

        public async Task<T> first(Expression<Func<T, bool>> predi)
        {
            T model = await _dbset.FirstOrDefaultAsync(predi);

            return model;
        }

        public async Task<T> singleasync(Expression<Func<T, bool>> predi)
        {
            return await _dbset.SingleAsync(predi);
        }

        public async Task<IEnumerable> GetAll()
        {
            return await _dbset.ToListAsync();
        }

        public IQueryable<T> search(Expression<Func<T, bool>> predi)
        {
            return _dbset.Where(predi);
        }

        public void add(T entity)
        {
            _dbset.Add(entity);
        }

        public void add(IEnumerable<T> entities)
        {
            _dbset.AddRange(entities);
        }

        public void add_adddependent(T entity)
        {
            _dbset.Add(entity, GraphBehavior.IncludeDependents);
        }

        public void add_adddependent(IEnumerable<T> entities)
        {
            _dbset.AddRange(entities, GraphBehavior.IncludeDependents);
        }

        public int count(Expression<Func<T, bool>> predi)
        {
            return _dbset.Count(predi);
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
            return _dbset.Any(predi);
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
            int num = _context.SaveChanges();
            return num;
        }

        public async Task<int> savechangesasync()
        {
            int num = await _context.SaveChangesAsync();
            return num;
        }
    }
}