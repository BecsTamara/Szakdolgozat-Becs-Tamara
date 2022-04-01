using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Szakdoga;
using Szakdoga.Configurations;
using Szakdoga.Contracts;
using Szakdoga.Data;
using Szakdoga.Repositories;
using Szakdoga.Repositories.Interfaces;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ApplicationDbContext.ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(ApplicationDbContext.ConnectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

SQL.ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDefaultIdentity<Employee>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ITableRepository, TableRepository>();
builder.Services.AddScoped<IFoodRepository, FoodRepository>();
builder.Services.AddScoped<IFoodTypeRepository, FoodTypeRepository>();
builder.Services.AddScoped<IFoodAllergyTypeRepository, FoodAllergyTypeRepository>();
builder.Services.AddScoped<IFoodAllergyRepository, FoodAllergyRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderFoodsRepository, OrderFoodsRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddAutoMapper(typeof(MapperConfig));

   

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
