using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SupplierManangement.Repository
{
    public class Repository<Entity> : IRepository<Entity> where Entity : class
    {
        public IBaseDbContext _DbsetContext { get; set; }
        public Repository(IBaseDbContext DbsetContext)
        {
            _DbsetContext = DbsetContext;
        }

        public bool Create(Entity entity)
        {
            try
            {
                _DbsetContext.GetDbContext.Add(entity);
                var result = _DbsetContext.GetDbContext.SaveChanges();
                if (result == 1)
                {
                    return  true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public void Delete(Entity entity)
        {
            _DbsetContext.GetDbContext.Set<Entity>().Remove(entity);
            _DbsetContext.GetDbContext.SaveChanges();
        }

        public IQueryable<Entity> Get()
        {
            return _DbsetContext.GetDbContext.Set<Entity>().AsQueryable().AsNoTracking();
        }

        public IQueryable<Entity> GetById(Expression<Func<Entity, bool>> predicate)
        {
            return _DbsetContext.GetDbContext.Set<Entity>().AsQueryable().Where(predicate);
        }

        public int Update(Entity entity)
        {
            _DbsetContext.GetDbContext.Add(entity);
            _DbsetContext.GetDbContext.Entry(entity).State = EntityState.Modified;
            return _DbsetContext.GetDbContext.SaveChanges(); ;
        }
    }
}
