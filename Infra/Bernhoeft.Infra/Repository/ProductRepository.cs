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

        public IQueryable<Product> GetAll( string filterDescription,
                                             string filterCategory,
                                             bool filterActive)
        {
            return _rep.List()
                 .Where(x => string.IsNullOrEmpty(filterDescription) || x.Description.ToUpper() == filterDescription.ToUpper())
                    .Where(x => string.IsNullOrEmpty(filterCategory) || x.Category.PropertyName.ToUpper() == filterCategory.ToUpper())
                    .Where(x => x.Situation == filterActive);
        }

        public void UpdateProduct(Product prod)
        =>  _rep.Update(prod);
        
    }
}
