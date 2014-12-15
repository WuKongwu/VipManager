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
     
        public Repository() {
            Logger = NullLogger.Instance;
        }

        public Vip.Logging.ILogger Logger { get; set; }

        public void Create(T entity)
        {
            this.Create(entity);
        }

        public void Update(T entity)
        {
            this.Update(entity);
        }

        public void Delete(T entity)
        {
            this.Delete(entity);
        }

      
        public void Flush()
        {
            this.Flush();
        }

        public T Get(int id)
        {
          return  this.Get(id);
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Table
        {
            get { throw new NotImplementedException(); }
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Fetch(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }


        //public virtual IQueryable<T> Table
        //{
        //    get { return Session.QueryOver<T>(); }//.Cacheable()
        //}

        //#region IRepository<T> Members

        //void IRepository<T>.Create(T entity) {
        //    Create(entity);
        //}

        //void IRepository<T>.Update(T entity) {
        //    Update(entity);
        //}

        //void IRepository<T>.Delete(T entity) {
        //    Delete(entity);
        //}

        //void IRepository<T>.Copy(T source, T target) {
        //    Copy(source, target);
        //}

        //void IRepository<T>.Flush() {
        //    Flush();
        //}

        //T IRepository<T>.Get(int id) {
        //    return Get(id);
        //}

        //T IRepository<T>.Get(Expression<Func<T, bool>> predicate) {
        //    return Get(predicate);
        //}

        //IQueryable<T> IRepository<T>.Table
        //{
        //    get { return Table; }
        //}

        //int IRepository<T>.Count(Expression<Func<T, bool>> predicate) {
        //    return Count(predicate);
        //}

        //IEnumerable<T> IRepository<T>.Fetch(Expression<Func<T, bool>> predicate) {
        //    return Fetch(predicate).ToReadOnlyCollection();
        //}

        //IEnumerable<T> IRepository<T>.Fetch(Expression<Func<T, bool>> predicate, Action<Orderable<T>> order) {
        //    return Fetch(predicate, order).ToReadOnlyCollection();
        //}

        //IEnumerable<T> IRepository<T>.Fetch(Expression<Func<T, bool>> predicate, Action<Orderable<T>> order, int skip,
        //                                    int count) {
        //    return Fetch(predicate, order, skip, count).ToReadOnlyCollection();
        //}

        //#endregion

        //public virtual T Get(int id) {
        //    return Session.Get<T>(id);
        //}

        //public virtual T Get(Expression<Func<T, bool>> predicate) {
        //    return Fetch(predicate).SingleOrDefault();
        //}

        //public virtual void Create(T entity) {
        //    Logger.Debug("Create {0}", entity);
        //    Session.Save(entity);
        //}

        //public virtual void Update(T entity) {
        //    Logger.Debug("Update {0}", entity);
        //    Session.Evict(entity);
        //    Session.Merge(entity);
        //}

        //public virtual void Delete(T entity) {
        //    Logger.Debug("Delete {0}", entity);
        //    Session.Delete(entity);            
        //}

        //public virtual void Copy(T source, T target) {
        //    Logger.Debug("Copy {0} {1}", source, target);
        //    var metadata = Session.SessionFactory.GetClassMetadata(typeof (T));
        //    var values = metadata.GetPropertyValues(source, EntityMode.Poco);
        //    metadata.SetPropertyValues(target, values, EntityMode.Poco);
        //}

        //public virtual void Flush() {
        //    Session.Flush();
        //}

        //public virtual int Count(Expression<Func<T, bool>> predicate) {
        //    return Fetch(predicate).Count();
        //}

        //public virtual IQueryable<T> Fetch(Expression<Func<T, bool>> predicate) {
        //    return Table.Where(predicate);
        //}

        //public virtual IQueryable<T> Fetch(Expression<Func<T, bool>> predicate, Action<Orderable<T>> order) {
        //    var orderable = new Orderable<T>(Fetch(predicate));
        //    order(orderable);
        //    return orderable.Queryable;
        //}

        //public virtual IQueryable<T> Fetch(Expression<Func<T, bool>> predicate, Action<Orderable<T>> order, int skip,
        //                                   int count) {
        //    return Fetch(predicate, order).Skip(skip).Take(count);
        //}


    }
}