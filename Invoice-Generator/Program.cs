using Microsoft.EntityFrameworkCore;
using Invoice_Generator.Controllers;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Domain.Entities.Identification;
using Infrastructure.Persistence;
using Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IDataBaseService, InvoiceGeneratorRepository>();

builder.Services.AddDbContext<DbCustContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("TwojaFaktura")));

void ConfigureServices(IServiceCollection services)
{
    services.AddIdentityCore<UserModel>(options =>
    {
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 5;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;

    }).AddEntityFrameworkStores<DbCustContext>();

}

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

//app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();