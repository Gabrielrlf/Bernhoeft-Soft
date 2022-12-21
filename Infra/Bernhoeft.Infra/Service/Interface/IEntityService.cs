using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernhoeft.Infra.Service.Interface
{
    interface IEntityService<T> where T : class
    {
        IQueryable<T> List();
        void Create(T obj);
        void Update(T obj);
        void Delete(T obj);
        T FindById(int? id);
    }
}
