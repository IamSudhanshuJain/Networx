using NetworxDataLayer.Entities;
using NetworxDataLayer.Interface;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace NetworxDataLayer
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private readonly OrganizationContext _context;
        private readonly DbSet<T> entity;
        public Repository()
        {
            _context = new OrganizationContext();
            entity = _context.Set<T>();
        }


        public DbRawSqlQuery<T> SQLQuery(string sql, params object[] parameters)
        {
            return _context.Database.SqlQuery<T>(sql, parameters);
        }

        public void Delete(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.Remove(data);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return entity;
        }
        public virtual T GetById(object Id)
        {
            return entity.Find(Id);
        }
        public void Insert(T data)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.Add(data);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.SaveChanges();
        }

    }
}
