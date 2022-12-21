using Bernhoeft.Infra.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernhoeft.Infra.Service
{
    public class EntityServiceRepository<T> : IDisposable, IEntityService<T> where T : class
    {
        public void Create(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T FindById(int? id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> List()
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
