using HotCatCafe.BLL.Repositories.Abstracts.EntityAbstract;
using HotCatCafe.BLL.ViewModels.CategoryViewModels;
using HotCatCafe.BLL.ViewModels.ProductViewModels;
using HotCatCafe.CMN.ImageHelpers;
using HotCatCafe.Model.Entities;
using HotCatCafe.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HotCatCafe.MVC.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProductController : Controller
    {
        private readonly IProductAccess _productAccess;
        private readonly ICategoryAccess _categoryAccess;

        public ProductController(IProductAccess productAccess, ICategoryAccess categoryAccess)
        {
            _productAccess = productAccess;
            _categoryAccess = categoryAccess;
        }
        public IActionResult Index()
        {
            var products = _productAccess.GetAllProducts().Select(x => new ProductViewModel
            {
                ProductId = x.ID,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                UnitInStock = x.UnitInStock,
                CategoryId = x.CategoryId,
                Status = x.Status,
                ImagePath = x.ImagePath,
            }).ToList();

            return View(products);
        }

        public IActionResult Create()
        {


            
            ViewBag.CategoryListItem = _categoryAccess.GetAllCategories().Select(x => new CategoryViewModel
            {
                CategoryName = x.CategoryName,
                Description = x.Description,
                Id = x.ID,
            }).Select(s => new SelectListItem
            {
                Text = s.CategoryName,
                Value = s.Id.ToString()
            });

            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel productViewModel, IFormFile productImage)
        {
            if (ModelState.IsValid)
            {

                var ImageEditResult = ImageHelper.UploadImage(productImage.FileName);

                if (ImageEditResult == "0")
                {
                    TempData["Error"] = "Görsel izin verilen formatta değil";
                    return View();
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", ImageEditResult);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        productImage.CopyToAsync(stream);
                    }


                    Product product = new Product
                    {
                        ID = productViewModel.ProductId,
                        ProductName = productViewModel.ProductName,
                        UnitPrice = productViewModel.UnitPrice,
                        UnitInStock = productViewModel.UnitInStock,
                        CategoryId = productViewModel.CategoryId,
                        Status = productViewModel.Status,
                        ImagePath = ImageEditResult
                    };

                    var result = await _productAccess.CreateProductAsync(product);

                    return RedirectToAction("Index", "Product");
                }


            }
            else
            {
                return View(productViewModel);
            }

        }


        [HttpGet]
        public async Task<IActionResult> CheckProductStockLow()
        {
            try
            {
                // Ürünlerin stok seviyelerini kontrol et ve e-posta bildirimi gönder
                IEnumerable<Product> lowStockProducts = await _productAccess.CheckProductStockLow();

                if (lowStockProducts == null || !lowStockProducts.Any())
                {
                    // Eğer düşük stoklu ürün bulunamazsa, uygun bir mesajla döner
                    ViewData["Message"] = "No products found with low stock.";
                    return View("NoProducts"); // "NoProducts.cshtml" adında bir görünüm dosyası
                }

                // Düşük stoklu ürünleri View'e gönder
                return View("LowStock", lowStockProducts); // "LowStock.cshtml" adında bir görünüm dosyası
            }
            catch (Exception ex)
            {
                // Hata durumunda uygun HTTP yanıtını döndürür
                ViewData["ErrorMessage"] = $"Internal server error: {ex.Message}";
                return View("Error"); // "Error.cshtml" adında bir görünüm dosyası
            }
        }
    }
}



    //[HttpGet]
    //    public IActionResult CheckStock()
    //    {
    //        // Sadece bir form gösteren bir View döndürür
    //        return View();
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> CheckStockAndNotify(int productId)
    //    {
    //        try
    //        {
    //            await _productAccess.CheckProductStockAndNotifyAsync(productId);
    //            return RedirectToAction("Index", new { message = "Stock check completed and notification sent if necessary." });
    //        }
    //        catch (Exception ex)
    //        {
    //            // Hata yönetimi
    //            // Hata mesajını ViewBag ile iletin
    //            ViewBag.ErrorMessage = $"Error: {ex.Message}";
    //            return View("Error"); // "Error" view'ını gösterir
    //        }
    //    }

    


