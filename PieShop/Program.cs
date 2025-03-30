using Microsoft.EntityFrameworkCore;
using PieShop.Models;
using PieShop.Models.Repositories.Interfaces;
using PieShop.Models.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();

builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PieShopDbContext>(options => {
    options.UseSqlServer(builder.Configuration["ConnectionStrings:PieShopDbContextConnection"]);
});

var app = builder.Build();

app.UseStaticFiles();
app.UseSession();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pie}/{action=List}"
);

DbInitializer.Seed(app);

app.Run();
