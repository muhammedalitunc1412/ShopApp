using System.Collections.Generic;
using ShopApp.Entity;

namespace DataAcces.Abstract
{
    public interface ICategoryRepository: IRepository<Category>
    {
        Category GetByWithProducts(int categoryId);
        void DeleteFromCategory(int productId, int categoryId);
    }
}