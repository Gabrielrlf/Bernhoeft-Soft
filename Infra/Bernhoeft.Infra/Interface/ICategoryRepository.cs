using Bernhoeft.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernhoeft.Infra.Interface
{
    public interface ICategoryRepository
    {
        public IQueryable<Category> GetAll(string filterCategory,
                                     bool? filterActive);
        public void CreateProduct(Category prod);
        public void DeleteProduct(Category prod);
        public Category FindById(int id);
        public void UpdateCategory(Category prod);
    }
}
