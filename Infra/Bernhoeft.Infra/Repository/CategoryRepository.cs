using Bernhoeft.Domain.Entity;
using Bernhoeft.Infra.Interface;
using Bernhoeft.Infra.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernhoeft.Infra.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IEntityService<Category> _rep;

        public CategoryRepository(IEntityService<Category> rep)
        {
            _rep = rep;
        }

        public void CreateProduct(Category category)
        => _rep.Create(category);

        public void DeleteProduct(Category category)
        {
            _rep.Delete(category);
        }

        public Category FindById(int id)
        {
            return _rep.FindById(id);
        }

        public IQueryable<Category> GetAll(string filterCategory, bool? filterActive)
        {
            return _rep.List()
                   .Where(x => x.PropertyName.ToUpper() == filterCategory.ToUpper() || string.IsNullOrEmpty(filterCategory));
        }

        public void UpdateCategory(Category category)
        {
            _rep.Update(category);
        }
    }
}
