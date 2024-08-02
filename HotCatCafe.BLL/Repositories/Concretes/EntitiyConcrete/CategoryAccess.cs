using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract;
using HotCatCafe.BLL.Repositories.Abstracts.EntityAbstract;
using HotCatCafe.Model.Entities;

namespace HotCatCafe.BLL.Repositories.Concretes.EntitiyConcrete
{
    public class CategoryAccess : ICategoryAccess
    {
        private readonly IDataAccess<Category> _categoryAccess;

        public CategoryAccess(IDataAccess<Category> categoryAccess) 
        {
            _categoryAccess = categoryAccess;
        }

      

        public async Task<string> CreateCategoryAsync(Category category)
        {
            try
            {
                return await _categoryAccess.Create(category);

            }
            catch (Exception ex)
            {

                return $"error creating category:{ex.Message}";
            }
        }

        public async Task<bool> DeleteCategory(Category category)
        {
            return await _categoryAccess.Delete(category);
        }

        public IEnumerable<Category> GetActiveCategory()
        {
            return _categoryAccess.GetActives();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryAccess.GetAll();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _categoryAccess.GetById(id);
        }

        public IEnumerable<Category> GetPassiveCategory()
        {
            return  _categoryAccess.GetPassive();
        }

        public async Task<string> UpdateCategory(Category category)
        {
            return await _categoryAccess.Update(category);
        }
    }
}
