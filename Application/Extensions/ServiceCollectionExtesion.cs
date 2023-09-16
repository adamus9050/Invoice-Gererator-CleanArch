using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using FluentValidation;
using Domain.Entities;
using Application.Mapping;
using MediatR;
using Application.Dto.Customer.Command.CustomerCommandAdd;
using Application.Dto.Material.MaterialCommand.Add;
using Application.Dto.Product.ProductCommand.Add;
using Application.ApplicationUser;
using Application.Dto.Order.Command.Add;

namespace Application.Extensions
{
    public static class ServiceCollectionExtesion
    {
        public static void AddInApplication(this IServiceCollection services)
        {
            services.AddScoped<IUserContext, UserContext>();
            
            services.AddMediatR(cfg => {
                cfg.RegisterServicesFromAssemblyContaining(typeof(CustomerSaveCommand));
                
            });

            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining(typeof(MaterialSaveCommand));
            });
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining(typeof(AddProductCommand));
            });
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining(typeof(AddOrderCommand));
            });
            //Mapowanie Dto
            services.AddAutoMapper(typeof(CustomerMappingProfile));
            services.AddAutoMapper(typeof(MaterialMappingProfile));
            services.AddAutoMapper(typeof(ProductMappingProfile));
            services.AddAutoMapper(typeof(OrderMappingProfile));


            //Dodawanie walidacji (fluent validation)
            services.AddValidatorsFromAssemblyContaining<CustomerSaveCommandValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();

            services.AddValidatorsFromAssemblyContaining<MaterialSaveCommandValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();

            services.AddValidatorsFromAssemblyContaining<ProductValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();

            services.AddValidatorsFromAssemblyContaining<AddressValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();
        }
    }
}
