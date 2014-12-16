using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vip.Data {
    public interface IRepository<T> {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        T GetById(int Id);
        T GetById(string Id);
        T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);   
    }
}