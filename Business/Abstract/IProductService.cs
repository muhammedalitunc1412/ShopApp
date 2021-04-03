using System.Collections.Generic;
using ShopApp.Entity;

namespace Business.Abstract
{
    public interface IProductService : IValidator<Product>
    {
        Product GetById(int id);
        Product GetProductDetails(string url);
        List<Product> GetAll();
        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);


        List<Product> GetProductsByCategory(string name, int page , int pageSize);
        bool Create(Product entity);
        bool Update(Product entity, int[] categoryIds);
        void Delete(Product entity);
        int GetCountByCategory(string category);

        Product GetByIdWithCategories(int id);

    }
}