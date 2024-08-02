using HotCatCafe.Model.Entities;

namespace HotCatCafe.BLL.Repositories.Abstracts.EntityAbstract
{
    public  interface ICategoryAccess
    {
        IEnumerable<Category> GetAllCategories();
        Task<Category> GetCategoryById(int id);

       
        Task<string> CreateCategoryAsync(Category category);
        

        Task<bool> DeleteCategory(Category category);

        Task<string> UpdateCategory(Category category);

        IEnumerable<Category> GetActiveCategory();

        IEnumerable<Category> GetPassiveCategory();

        



    }
}
