using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NetworxDataLayer.Entities;

namespace NetworxDataLayer.Interface
{
    public interface IRepository<T> where T:class
    {
        DbRawSqlQuery<T> SQLQuery(string sql, params object[] parameters);
        IQueryable<T> GetAll();
        T GetById(object Id);
        void Delete(T data);
        void Insert(T data);
        void Update(T entity);
    }
}
