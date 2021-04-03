using System.Collections.Generic;
using Business.Abstract;
using DataAcces.Abstract;
using ShopApp.Entity;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository=categoryRepository;
        }

      

        public void Create(Category entity)
        {
        _categoryRepository.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public void DeleteFromCategory(int productId, int categoryId)
        {
            _categoryRepository.DeleteFromCategory(productId,categoryId);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Category GetByWidthCategory(int categoryId)
        {
            return _categoryRepository.GetByWithProducts(categoryId);
        }

        public void Update(Category entity)
        {
             _categoryRepository.Update(entity);
        }

        public string ErrorMessage { get; set; }
        public bool Validation(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}