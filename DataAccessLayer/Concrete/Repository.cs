using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        public void Add(T entity)
        {
            using (Context context = new Context())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (Context context = new Context())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
            }

        }
        public T GetById(Expression<Func<T, bool>> filter)
        {
            using (Context context = new Context())
            {
                return context.Set<T>().FirstOrDefault(filter);
            }
        }

        public T GetId(int id)
        {
            using (Context context = new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public void Update(T entity)
        {
            using (Context context = new Context())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
