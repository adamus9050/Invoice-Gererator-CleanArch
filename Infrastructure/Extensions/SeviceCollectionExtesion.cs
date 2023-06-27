using Domain.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure.Extensions
{
    public static class SeviceCollectionExtesion
    {
        public static void AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<DbCustContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("TwojaFaktura")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<DbCustContext>();

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IHomeRepository, HomeRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
