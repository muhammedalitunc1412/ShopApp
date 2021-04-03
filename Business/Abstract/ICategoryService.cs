using System.Collections.Generic;
using ShopApp.Entity;

namespace Business.Abstract
{
    public interface ICategoryService:IValidator<Category>
    {
        Category GetByWidthCategory(int categoryId);

        void DeleteFromCategory(int productId, int categoryId);
        Category GetById(int id);

        List<Category> GetAll();

        void Create(Category entity);

        void Update(Category entity);
        void Delete(Category entity);
    }
}