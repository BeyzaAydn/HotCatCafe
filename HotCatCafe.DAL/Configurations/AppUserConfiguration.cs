using Bogus;
using HotCatCafe.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotCatCafe.DAL.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            //Properties
            builder.Property(x=>x.UserName).HasMaxLength(255);
            builder.Property(x=>x.PasswordHash).HasMaxLength(25);

            //HasData
            builder.HasData(SeedAppUserData());
        }

        public List<AppUser> SeedAppUserData()
        {
            var fakeAppUserData = new Faker<AppUser>("en")
                .RuleFor(x => x.UserName, f => f.Name.ToString())
                .RuleFor(x => x.Email, f => f.Internet.Email())
                .RuleFor(x => x.PasswordHash, f => f.Internet.Password());
               


            List<AppUser> appUsers = fakeAppUserData.Generate(10);

            foreach (var appUser in appUsers)
            {
                appUser.Id=Guid.NewGuid();
            }

            

            

            return appUsers;

        }
    }
}
