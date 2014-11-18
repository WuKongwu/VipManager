using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VIP.Base.Interface.Models;
using System.Data.Entity;
using System.Data;

namespace VIP.Base.Interface.Business
{
    public class ObjectBusiness<TEntity> where TEntity : ObjectModel
    {
        /// <summary>
        /// 获取全部
        /// </summary>
        /// <param name="db">数据库</param>
        /// <returns></returns>
        public virtual List<TEntity> GetList(DbContext db)
        {
           return db.Set<TEntity>().ToList();
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="db">数据库</param>
        /// <param name="model">实体类</param>
        public virtual void Create(DbContext db, TEntity model)
        {
            model.ID = new Guid().ToString();
            model.CreateTime = DateTime.Now;
            db.Set<TEntity>().Add(model);
            db.SaveChanges();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="db">数据库</param>
        /// <param name="id">Id</param>
        public virtual void Delete(DbContext db, string id)
        {
            var aimobj = db.Set<TEntity>().Where(m => m.ID == id).FirstOrDefault();
            if (aimobj != null)
            {
                db.Set<TEntity>().Remove(aimobj);
            }
        }

        /// <summary>
        /// 更新修改
        /// </summary>
        /// <param name="db">数据库</param>
        /// <param name="model">实体类</param>
        public virtual void Modify(DbContext db, TEntity model) 
        {
            if (model != (TEntity)null)
            {
                db.Entry<TEntity>(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            else
            {

            }
        }


        //public DbResultModel CheckRepeate(TDbContext db, TObject model)
        //{
        //    List<PropertyInfo> properlist = typeof(TObject).GetObjectFieldByAttribute<OSCheckRepeate>();
        //    Type modelType = model.GetType();
        //    foreach (var item in properlist)
        //    {
        //        ParameterExpression left = Expression.Parameter(typeof(TObject), "m");
        //        PropertyInfo propertyInfo = modelType.GetProperty(item.Name);
        //        PropertyInfo propertyInfoID = modelType.GetProperty(ObjectModel.IDNAME);

        //        Expression expression = Expression.NotEqual(Expression.Property(left, typeof(TObject).GetProperty(ObjectModel.IDNAME)), Expression.Constant(propertyInfoID.GetValue(model)));
        //        Expression right = Expression.Equal(Expression.Property(left, typeof(TObject).GetProperty(item.Name)), Expression.Constant(propertyInfo.GetValue(model)));
        //        expression = Expression.And(right, expression);

        //        Expression<Func<TObject, bool>> exp = Expression.Lambda<Func<TObject, bool>>(expression, left);
        //        if (db.Set<TObject>().Where(exp).Any())
        //        {
        //            string errorMessage = DicBaseMessage.ResourceManager.GetString("FieldRepeate") ?? "{0} 已存在，请重新输入";
        //            errorMessage = string.Format(errorMessage, item.GetCustomAttribute<OSDisplayName>().DisplayName);
        //            Dictionary<string, string> modelVaild = new Dictionary<string, string>();
        //            modelVaild.Add(item.Name, errorMessage);
        //            return new DbResultModel { State = DbResultState.WARN, ModelValide = modelVaild };
        //        }
        //    }
        //    return null;
        //}
    }
}
