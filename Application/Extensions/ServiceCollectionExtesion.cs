using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Services;

namespace Application.Extensions
{
    public static class ServiceCollectionExtesion
    {
        public static void AddInApplication(this IServiceCollection services)
        {
            services.AddScoped<IDataCustomerService, DataCustomerService>();
            services.AddScoped<IDataHomeService, DataHomeService>();

        }
    }
}
