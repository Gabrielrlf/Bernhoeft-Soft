using Bernhoeft.Domain.Entity;
using Bernhoeft.Infra.Interface;
using Bernhoeft.Infra.Service;
using Bernhoeft.Infra.Service.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bernhoeft.Infra.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IEntityService<Product> _rep;

        public ProductRepository(IEntityService<Product> rep)
        {
            _rep = rep;
        }

        public void CreateProduct(Product prod)
        => _rep.Create(prod);

        public void DeleteProduct(Product prod)
        {
            _rep.Delete(prod);
        }

        public Product FindById(int id)
        {
            return _rep.FindById(id);
        }

        public IQueryable<Product> GetAll()
        {
            return _rep.List();
        }

        public void UpdateProduct(Product prod)
        =>  _rep.Update(prod);
        
    }
}
