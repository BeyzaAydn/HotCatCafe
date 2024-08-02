using HotCatCafe.DAL.Configurations;
using HotCatCafe.Model.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace HotCatCafe.DAL.Context
{
   public class HotCatCafeContext:IdentityDbContext<AppUser,AppUserRole,Guid>
    {

        public HotCatCafeContext(DbContextOptions<HotCatCafeContext> options):base(options) { }
        //DbSets
        //Category DbSet
        public DbSet<Category> Categories { get; set; }

        //ProductDbSet
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("server=BEYZA\\SQLEXPRESS; database=HotCafeDB;Trusted_Connection=True;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new AppUserConfiguration());
            base.OnModelCreating(builder);
        }

    }
}
