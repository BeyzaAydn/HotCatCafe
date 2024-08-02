using HotCatCafe.BLL.Repositories.Abstracts.EntityAbstract;
using HotCatCafe.BLL.ViewModels;
using HotCatCafe.BLL.ViewModels.CategoryViewModels;
using HotCatCafe.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotCatCafe.MVC.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        private readonly ICategoryAccess _categoryAccess;

        public CategoryController(ICategoryAccess categoryAccess) 
        {
            _categoryAccess = categoryAccess;
        }

        //Category İndex sayfasında tüm kategoriler gösterilecek
        public IActionResult Index()
        {
            var categories=_categoryAccess
                .GetAllCategories()
                .OrderByDescending(x=>x.CreatedDate)
                 .Select(x => new CategoryListViewModel
                 {
                     Id = x.ID,
                     CategoryName = x.CategoryName,
                     Description = x.Description,
                     Active = x.Active,
                     Status = x.Status
                 })
                .ToList();
            return View(categories);
        }

        //Ürün ekleme 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category
                {
                    CategoryName = categoryViewModel.CategoryName,
                    Description = categoryViewModel.Description,
                };

                string result = await _categoryAccess.CreateCategoryAsync(category); 

                
                
                    return RedirectToAction("Index", "Category"); // Başarılı işlem sonrası yönlendirme.
                
                
            }
            else
            {
                return View(categoryViewModel); // ModelState geçerli değilse veya oluşturma başarısız olursa aynı view döndürülüyor.
            }



            
        }

        //Ürün güncelleme
        public async Task<IActionResult> Update(int id)
        {
            var category = await _categoryAccess.GetCategoryById(id);

            if (category == null)
            {
                return RedirectToAction("Index","Category");
            }

            CategoryListViewModel categoryListViewModel = new CategoryListViewModel
            {
                CategoryName = category.CategoryName,
                Description = category.Description,
                Active = category.Active,
                Status = category.Status
            };

            return View(categoryListViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryListViewModel category)
        {
            if (ModelState.IsValid)
            {
                Category updated = new Category
                {
                    ID = category.Id,
                    CategoryName = category.CategoryName,
                    Description = category.Description,
                   Active = category.Active,
                    Status = category.Status
                };

                var result = await _categoryAccess.UpdateCategory(updated);
                
                return RedirectToAction("Index","Category");
            }
            else
            {
                return View(category);
            }

        }

        


        // HttpGet metodu: Silme işlemi için onay sayfasını gösterir.
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryAccess.GetCategoryById(id);
            if (category == null)
            {
                return NotFound(); // Kategori bulunamazsa 404 döner.
            }

            var categoryViewModel = new CategoryViewModel
            {
                Id = category.ID,
                CategoryName = category.CategoryName,
                Description = category.Description,
            };

            return View(categoryViewModel);
        }

        // HttpPost metodu: Silme işlemini gerçekleştirir.
        [HttpPost, ActionName("Delete")]
       
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _categoryAccess.GetCategoryById(id);
            if (category == null)
            {
                return NotFound(); // Kategori bulunamazsa 404 döner.
            }

            try
            {
                var isDeleted = await _categoryAccess.DeleteCategory(category);
                if (isDeleted)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Silme işlemi başarısız oldu. Lütfen tekrar deneyin.");
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını kullanıcıya göster.Bu metodun açıklamasına çalış..
                ModelState.AddModelError("", $"Silme işlemi sırasında bir hata oluştu: {ex.Message}");
            }

            var categoryViewModel = new CategoryViewModel
            {
                Id = category.ID,
                CategoryName = category.CategoryName,
                Description = category.Description,
            };
            return View(categoryViewModel); // Hata durumunda onay sayfasına geri döner.
        }

        // Active Categorilerin listelenmesi
        public IActionResult Active()
        {
            var categories = _categoryAccess
                .GetActiveCategory()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new CategoryListViewModel
                {
                    Id = x.ID,
                    CategoryName = x.CategoryName,
                    Description = x.Description,
                    Active = x.Active,
                    Status = x.Status
                }).ToList();
            return View(categories);
        }

        ///List Passive Categories
        public IActionResult Passive()
        {
            var categories = _categoryAccess
                .GetPassiveCategory()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new CategoryListViewModel
                {
                    Id = x.ID,
                    CategoryName = x.CategoryName,
                    Description = x.Description,
                    Active = x.Active,
                    Status = x.Status
                }).ToList();
            return View(categories);
        }




    }
    }


