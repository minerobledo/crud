using Microsoft.Extensions.Configuration;
using PrimerCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.AspNetCore.Identity;
using PrimerCRUD.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddControllers();
var Configuration = builder.Configuration;




builder.Services.AddDbContext<MyIdentitiDBCRUDContext>(options => options.UseSqlServer(builder.Configuration["ConnectionString:conexion"]));
builder.Services.AddIdentity<MyUsruario, MyRol>
    (
        Option =>
        {
            // opciones de usuario
            Option.User.RequireUniqueEmail = true;

            //opciones de contracenña
            Option.Password.RequireDigit = true;
            Option.Password.RequiredLength = 8;
            Option.Password.RequireUppercase = true;
            Option.Password.RequireLowercase = true;
            Option.Password.RequireNonAlphanumeric = true;

            //opciones de tokems
            Option.Lockout.AllowedForNewUsers = true;
            }
    ).AddDefaultTokenProviders().AddEntityFrameworkStores<MyIdentitiDBCRUDContext>();




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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
