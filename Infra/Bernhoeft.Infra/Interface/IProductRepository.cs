using Bernhoeft.Domain.Entity;
using Bernhoeft.Infra.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernhoeft.Infra.Interface
{
    public interface IProductRepository
    {
        public IQueryable<Product> GetAll();
        public void CreateProduct(Product prod);
        public void DeleteProduct(Product prod);
        public Product FindById(int id);
        public void UpdateProduct(Product prod);
    }
}
