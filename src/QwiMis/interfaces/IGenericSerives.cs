using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QwiMis.interfaces
{
    public interface IGenericSerives<T> where T : class, new()
    {
        Task<IEnumerable> getall();

        Task<T> first(Expression<Func<T, bool>> predi);

        Task<T> singleasync(Expression<Func<T, bool>> predi);

        IQueryable<T> search(Expression<Func<T, bool>> predi);

        void add(T entity);

        void add(IEnumerable<T> entities);

        void add_adddependent(T entity);

        void add_adddependent(IEnumerable<T> entities);

        int count(Expression<Func<T, bool>> predi);

        void update(T entity);

        void update_range(IEnumerable<T> entities);

        void update_adddependent(T entity);

        void update_adddependent(IEnumerable<T> entities);

        bool recordpresent(Expression<Func<T, bool>> predi);

        void remove(T entity);

        void remove(IEnumerable<T> entities);

        int savechanges();

        Task<int> savechangesasync();
    }
}