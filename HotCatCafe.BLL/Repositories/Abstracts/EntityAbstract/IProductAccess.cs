using HotCatCafe.Model.Entities;

namespace HotCatCafe.BLL.Repositories.Abstracts.EntityAbstract
{
    public interface IProductAccess
    {
        IEnumerable<Product> GetAllProducts();
        Task<Product> GetProductByIdAsync(int id);


        Task<string> CreateProductAsync(Product product);


        Task<bool> DeleteProductAsync(Product product);

        Task<string> UpdateProductAsync(Product product);

        IEnumerable<Product> GetActiveProduct();

        IEnumerable<Product> GetPassiveProduct();

        IEnumerable<Product> LowProductList();

        Task<IEnumerable<Product>> CheckProductStockLow();//stoğu 10 nin aşağısında olan ürünün yakalanması
        Task CheckProductStockAndNotifyAsync(IEnumerable<Product> lowstockProducts);//mail gönderilmesi
    }
}
