using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Application.Services;
using FluentValidation.AspNetCore;
using FluentValidation;
using Domain.Entities;
using Application.Mapping;
using MediatR;
using Application.Dto.Customer.Command.CustomerCommandAdd;
using Application.Dto.Material.MaterialCommand.Add;


namespace Application.Extensions
{
    public static class ServiceCollectionExtesion
    {
        public static void AddInApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => {
                cfg.RegisterServicesFromAssemblyContaining(typeof(CustomerSaveCommand));
                
            });
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining(typeof(MaterialSaveCommand));
            });
            //Mapowanie Dto
            services.AddAutoMapper(typeof(CustomerMappingProfile));
            services.AddAutoMapper(typeof(MaterialMappingProfile));

            //Dodawanie walidacji (fluent validation)
            services.AddValidatorsFromAssemblyContaining<CustomerSaveCommandValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();

            services.AddValidatorsFromAssemblyContaining<MaterialSaveCommandValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();

            services.AddValidatorsFromAssemblyContaining<AddressValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();
        }
    }
}
