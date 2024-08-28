using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract;
using HotCatCafe.BLL.Repositories.Abstracts.EntityAbstract;
using HotCatCafe.CMN.EmailHelpers;
using HotCatCafe.Model.Entities;
using System.Collections.Generic;


namespace HotCatCafe.BLL.Repositories.Concretes.EntitiyConcrete
{
    public class ProductAccess : IProductAccess
    {
        private readonly IDataAccess<Product> _productAccess;
       


        public ProductAccess(IDataAccess<Product> productAccess)
        {
            _productAccess = productAccess;
        }
        public async Task<string> CreateProductAsync(Product product)
        {
            try
            {
                return await _productAccess.Create(product);

            }
            catch (Exception ex)
            {

                return $"error creating product:{ex.Message}";
            }
        }

        public async Task<bool> DeleteProductAsync(Product product)
        {
            return await _productAccess.Delete(product);
        }

        public IEnumerable<Product> GetActiveProduct()
        {
            return _productAccess.GetActives();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productAccess.GetAll();
        }

        public IEnumerable<Product> GetPassiveProduct()
        {
            return _productAccess.GetPassive();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productAccess.GetById(id);
        }

        public async Task<string> UpdateProductAsync(Product product)
        {
            return await _productAccess.Update(product);
        }

        /// <summary>
        /// stok miktarı 10'un altında olan ürünleri yakalar ve mail gönderilmesi için CheckProductStockAndNotifyAsync metpdunun parametresine iletir.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> CheckProductStockLow()
        {
            // Tüm ürünleri al
            var allProducts = GetAllProducts();
            int threshold = 10;
            // Stok miktarı eşik değerinin altında olan ürünleri filtrele
            var lowStockProducts = allProducts.Where(product => product.UnitInStock < threshold);
           await CheckProductStockAndNotifyAsync(lowStockProducts);
            return lowStockProducts;
        }

        /// <summary>
        /// stok miktarı 10'un altıdan olan ürünleri listeler.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> LowProductList()
        {
            // Tüm ürünleri alır
            var allProducts = GetAllProducts();
            int threshold = 10;
            // Stok miktarı eşik değerinin altında olan ürünleri filtrele
            var lowStockProducts = allProducts.Where(product => product.UnitInStock < threshold);
           
            return lowStockProducts;
        }

        public async Task CheckProductStockAndNotifyAsync(IEnumerable<Product> lowStockProducts)
        {
           
            if (lowStockProducts != null)
            {
                string subject = "Düşen Stok Uyarısı";
                foreach (var product in lowStockProducts)
                {
                    string body = $" (ProductName:{product.ProductName})-(ID: {product.ID}) ürününde stok miktarı asgari belirlenen rakam olan 10'un altına düşmüştür.Acilen tedarik işleminin başlatılması gerekmektedir.Güncel Stok: {product.UnitInStock}";
                    // Asenkron e-posta gönderimi
                     EmailSender.SendEmail("bkucuk.33@gmail.com", subject, body);
                }
            }
        }

       

        
    }
}
