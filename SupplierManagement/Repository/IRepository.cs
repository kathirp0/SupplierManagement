using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SupplierManangement.Repository
{
    public interface IRepository<Entity> where Entity : class
    {
        bool Create(Entity entity);
        void Delete(Entity entity);
        int Update(Entity entity);
        IQueryable<Entity> Get();
        IQueryable<Entity> GetById(Expression<Func<Entity, bool>> predicate);
    }
    public interface IBaseDbContext : IDisposable
    {
        DbContext GetDbContext { get; }
    }
}

