using HotCatCafe.BLL.Repositories.Abstracts.EntityAbstract;
using HotCatCafe.BLL.ViewModels;
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
                // Ürünlerin stok seviyelerini kontrol eder ve e-posta bildirimi gönderir.
                IEnumerable<Product> lowStockProducts = await _productAccess.CheckProductStockLow();

                if (lowStockProducts == null || !lowStockProducts.Any())
                {
                    // Eğer düşük stoklu ürün bulunamazsa, uygun bir mesajla döner
                    
                    return View("NoLowStock"); 
                }

                
                return View(); 
            }
            catch (Exception ex)
            {
                // Hata durumunda uygun HTTP yanıtını döndürür
               
                return View("Error"); // 
            }

            
        }
        public  IActionResult LowProductList()
        {
            try
            {
                // Düşük stoklu ürünleri al
                var lowStockProducts =  _productAccess.LowProductList().Select(x => new ProductViewModel
                {
                    ProductId = x.ID,
                    ProductName = x.ProductName,
                    UnitPrice = x.UnitPrice,
                    UnitInStock = x.UnitInStock,
                    CategoryId = x.CategoryId,
                    Status = x.Status,
                    ImagePath = x.ImagePath,
                }).ToList();

                

                // Eğer düşük stoklu ürün bulunamazsa, uygun bir mesaj ile görünüm döndür
                if (lowStockProducts == null || !lowStockProducts.Any())
                {

                    return View("NoLowStock"); // "NoLowStock.cshtml" adında bir görünüm dosyası döndürür
                }

                // Düşük stoklu ürünleri View'e gönder
                return View(lowStockProducts);
            }
            catch (Exception ex)
            {
                // Hata durumunda uygun HTTP yanıtını döndürür
               
                return View("Error"); // "Error.cshtml" adında bir görünüm dosyası döndürür
            }


        }


        //Ürün güncelleme
        public async Task<IActionResult> Update(int id)
        
        
        
       {
            var product = await _productAccess.GetProductByIdAsync(id);

            if (product == null)
            {
                return RedirectToAction("Index", "Product");
            }

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

            ProductViewModel productViewModel = new ProductViewModel
            {
                ProductName = product.ProductName,
                ProductId = product.ID,
               UnitInStock= product.UnitInStock,
               CategoryId = product.CategoryId,
               Status = product.Status,
               ImagePath = product.ImagePath,
               UnitPrice= product.UnitPrice,
            };

            return View(productViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductViewModel productViewModel, IFormFile productImage)
        {
            if (ModelState.IsValid)
            {
                var ImageEditResult = ImageHelper.UploadImage(productImage.FileName);

                if (ImageEditResult == "0")
                {
                    TempData["Error"] = "Görsel izin verilen formatta değil";
                    return View(productViewModel);
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", ImageEditResult);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                       await productImage.CopyToAsync(stream);
                    }


                    Product updated = new Product
                    {

                        ProductName = productViewModel.ProductName,
                        UnitPrice = productViewModel.UnitPrice,
                        UnitInStock = productViewModel.UnitInStock,
                        CategoryId = productViewModel.CategoryId,
                        Status = productViewModel.Status,
                        ImagePath = ImageEditResult,
                    };

                    var result = await _productAccess.UpdateProductAsync(updated);

                    return RedirectToAction("Index", "Category");
                }
            }
            else
            {
                return View();
            }

        }


        // HttpGet metodu: Silme işlemi için onay sayfasını gösterir.
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productAccess.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound(); // Kategori bulunamazsa 404 döner.
            }

            var productViewModel = new ProductViewModel
            {
                ProductId = product.ID,
                ProductName = product.ProductName,
                
            };

            return View(productViewModel);
        }

        // HttpPost metodu: Silme işlemini gerçekleştirir.
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _productAccess.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound(); // Kategori bulunamazsa 404 döner.
            }

            try
            {
                var isDeleted = await _productAccess.DeleteProductAsync(product);
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

            var productViewModel = new ProductViewModel
            {
                ProductId= product.ID,
                ProductName = product.ProductName,
                
            };
            return View(productViewModel); // Hata durumunda onay sayfasına geri döner.
        }


        // Active Ürünlerin listelenmesi
        public IActionResult Active()
        {
            var products = _productAccess
                .GetActiveProduct()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new ProductViewModel
                {
                    ProductId = x.ID,
                    ProductName = x.ProductName,
                    UnitInStock = x.UnitInStock,
                    UnitPrice = x.UnitPrice,
                    Active = x.Active,
                    Status = x.Status
                }).ToList();
            return View(products);
        }

        //List Passive Products
        public IActionResult Passive()
        {
            var products = _productAccess
                .GetPassiveProduct()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new ProductViewModel
                {
                    ProductId = x.ID,
                    ProductName = x.ProductName,
                    UnitInStock = x.UnitInStock,
                    UnitPrice = x.UnitPrice,
                    Active = x.Active,
                    Status = x.Status
                }).ToList();
            return View(products);
        }

    }
}



    
    


