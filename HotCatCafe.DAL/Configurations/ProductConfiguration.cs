using HotCatCafe.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bogus;

namespace HotCatCafe.DAL.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //Fluent APİ:Fluent API, genellikle yapılandırma ve ayarların daha kolay ve doğal bir şekilde ifade edilmesi için kullanılan programlama tekniğidir.
            builder.HasOne(x=>x.Category).WithMany(x=>x.Products).HasForeignKey(x=>x.CategoryId);
            //Properties

            //HasData
            builder.HasData(SeedProductData());



        }
        public List<Product> SeedProductData()
        {
            // Bogus: Fake datalar oluşturulmasına olanak sağlar ücretsiz bir kütüphanedir.
            var fakeData = new Faker();
            List<Product> products = new List<Product>();

            // 3 kategori için ürünler oluşturuluyor
            for (int i = 1; i <= 3; i++)
            {
                // Her kategori için 10 ürün oluşturuluyor
                for (int z = 1; z <= 10; z++)
                {
                    Product product = new Product
                    {
                        ID = (i - 1) * 10 + z, // ID'ler 1'den 30'a kadar
                        ProductName = fakeData.Commerce.Product(), // Rastgele ürün ismi
                        CategoryId = i, // Kategori ID'si: 1, 2 veya 3
                        UnitPrice = decimal.Parse(fakeData.Commerce.Price(min: 100, max: 10000, 2)), // Rastgele fiyat
                        UnitInStock = fakeData.Random.Short(min: 1, max: 100), // Rastgele stok miktarı
                        Quantity = fakeData.Random.Int(min: 1, max: 100),
                        Discount = fakeData.Random.Decimal()
                    };
                    products.Add(product);
                }
            }

            return products;
        }
    }
}
