using HotCatCafe.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bogus;

namespace HotCatCafe.DAL.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Description).HasMaxLength(255);
            builder.Property(x=>x.CategoryName).HasMaxLength(255);

            builder.HasData(SeedCategoryData());
        }

        public List<Category> SeedCategoryData() 
        {
            var categoryFaker = new Faker<Category>("en")
               .RuleFor(c => c.CategoryName, f => f.Commerce.Categories(1).First())
               .RuleFor(c => c.Description, f => f.Lorem.Sentence());
            List<Category> categories=categoryFaker.Generate(3);

            int id = 1;
            foreach (var category in categories)
            {
                category.ID = id++;
            }

            return categories;
        
        }

    }
}
