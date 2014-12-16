using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using log4net.Core;
using Vip.Logging;
using System.Data.Entity;

namespace Vip.Data {
    public class Repository<T> : DbContext, IRepository<T> where T : class
    {
        private DataContext dataContext;
        private readonly IDbSet<T> dbSet;
     
        public Repository() {
            Logger = NullLogger.Instance;
            dbSet = dataContext.Set<T>();
        }

        public Vip.Logging.ILogger Logger { get; set; }

        public void Add(T entity)
        {
            dbSet.Add(entity);         
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }
        
        public void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        public T GetById(int Id)
        {
            return dbSet.Find(Id);
        }

        public T GetById(string Id)
        {
            return dbSet.Find(Id);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).ToList();
        }
    }
}