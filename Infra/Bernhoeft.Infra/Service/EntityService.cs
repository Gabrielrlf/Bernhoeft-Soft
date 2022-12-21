using Bernhoeft.Infra.Context;
using Bernhoeft.Infra.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernhoeft.Infra.Service
{
    public class EntityService<T> : IDisposable, IEntityService<T> where T : class
    {
        private readonly ProductDbContext _dbContext;

        public EntityService(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(T obj)
        {
            _dbContext.Set<T>().Add(obj);

            _dbContext.SaveChanges();
        }

        public void Delete(T obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
        }

        public void Dispose()
        => _dbContext.Dispose();

        public T FindById(int? id)
        => _dbContext.Find<T>(id);

        public IQueryable<T> List() => _dbContext.Set<T>();

        public void Update(T obj)
        {
            _dbContext.Entry(obj).State = EntityState.Modified;

            _dbContext.SaveChanges();
        }
    }
}
