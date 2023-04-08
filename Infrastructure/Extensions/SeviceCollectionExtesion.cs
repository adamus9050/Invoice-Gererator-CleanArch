using Domain.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class SeviceCollectionExtesion
    {
        public static void AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<DbCustContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("TwojaFaktura")));

            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
