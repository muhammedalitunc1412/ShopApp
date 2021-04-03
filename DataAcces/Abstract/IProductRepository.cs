using ShopApp.Entity;
using System.Collections.Generic;

namespace DataAcces.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
        List<Product> GetProductsByCategory(string name,int page,int pageSize);
        Product GetProductDetails(string url);
       List<Product> GetSearchResult(string searchString);
       List<Product> GetHomePageProducts();
        Product GetByIdWithCategories(int id);
        void Update(Product entity, int[] categoryIds);

        int GetCountByCategory(string category);

    }
}