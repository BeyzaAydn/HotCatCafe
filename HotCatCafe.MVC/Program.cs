
using Microsoft.EntityFrameworkCore;
using HotCatCafe.DAL.Context;
using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract;
using HotCatCafe.BLL.Repositories.Concretes.BaseConcrete;
using HotCatCafe.BLL.Repositories.Abstracts.EntityAbstract;
using HotCatCafe.BLL.Repositories.Concretes.EntitiyConcrete;
using Microsoft.AspNetCore.Identity;
using NETCore.MailKit.Core;
using HotCatCafe.Model.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Dependency Injection Services
//AddDbContext
builder.Services.AddDbContext<HotCatCafeContext>(options => options.UseSqlServer("server=BEYZA\\SQLEXPRESS; database=HotCafeDB;Trusted_Connection=True;TrustServerCertificate=true",b=>b.MigrationsAssembly("HotCatCafe.MVC")));


//Repository Access
builder.Services.AddScoped(typeof (IDataAccess<>), typeof (DataAccess<>)); 

//Entity Access
builder.Services.AddScoped<ICategoryAccess,CategoryAccess>();

builder.Services.AddScoped<IProductAccess,ProductAccess>();

//User Manager
builder.Services.AddIdentity<AppUser,AppUserRole>().AddEntityFrameworkStores<HotCatCafeContext>().AddDefaultTokenProviders();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//MapControllerRoute daha tekil(projemizin sadece MVC projesi olarak ilerlemesi durumunda)
//UseEndpoints ilerde Api-nin projeye dahil olmas? durumunda kulland?m.
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
      name: "activationUrl",
    pattern: "{controller=Home}/{action=Activation}/{id}/{token}"
    );



    endpoints.MapControllerRoute(
      name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
});


app.Run();
