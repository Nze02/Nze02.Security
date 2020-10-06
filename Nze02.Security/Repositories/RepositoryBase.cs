using Microsoft.EntityFrameworkCore;
using Nze02.Security.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Nze02.Security.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationDbContext _db;

        public RepositoryBase(ApplicationDbContext db)
        {
            _db = db;
        }

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
            _db.Set<T>()
            .AsNoTracking() :
            _db.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ? _db.Set<T>()
            .Where(expression)
            .AsNoTracking() : _db.Set<T>()
            .Where(expression);

        public void Create(T entity) => _db.Set<T>().Add(entity);
        public void Update(T entity) => _db.Set<T>().Update(entity);
        public void Delete(T entity) => _db.Set<T>().Remove(entity);
    }
}
