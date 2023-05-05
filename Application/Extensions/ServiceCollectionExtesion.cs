using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Services;
using FluentValidation.AspNetCore;
using FluentValidation;
using Domain.Entities;
using Application.Mapping;

namespace Application.Extensions
{
    public static class ServiceCollectionExtesion
    {
        public static void AddInApplication(this IServiceCollection services)
        {
            services.AddScoped<IDataCustomerService, DataCustomerService>();
            services.AddScoped<IDataHomeService, DataHomeService>();
           
            //Mapowanie Dto
            services.AddAutoMapper(typeof(CustomerMappingProfile));

            //Dodawanie walidacji (fluent validation)
            services.AddValidatorsFromAssemblyContaining<CustomerDtoValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();

            services.AddValidatorsFromAssemblyContaining<AddressValidator>()
                    .AddFluentValidationAutoValidation()
                    .AddFluentValidationClientsideAdapters();
        }
    }
}
