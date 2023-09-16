using Application.Dto;
using AutoMapper;
using Domain.Entities;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<OrderDto, Order>()
                .ForMember(e => e.Customers, opt => opt.MapFrom(src => new Customer()
                {
                    CustomerId = src.CustomerId,    
                    Name = src.CustomerName,
                    Surname = src.Surname,
                    PhoneNumber = src.PhoneNumber,
                    EmailAdress = src.EmailAdres
                }))
            .ForMember(e => e.Products, opt => opt.MapFrom(src => new Product()
            {
                ProductId= src.ProductId,
                ProductName = src.ProductName,
                Type = src.Type,
                ProductPrice = src.ProductPrice
            }))
            .ForMember(e => e.Materials, opt => opt.MapFrom(src => new Material()
            {
                MaterialId= src.MaterialId,
                Name=src.MaterialName,
                Description = src.MaterialDescription,
                Price = src.MaterialPrice
            }));


            CreateMap< Order,OrderDto>()
                .ForMember(dto => dto.CustomerId, opt => opt.MapFrom(src => src.CustomersId))
                .ForMember(dto => dto.CustomerName, opt => opt.MapFrom(src => src.Customers.Name))
                .ForMember(dto => dto.Surname, opt => opt.MapFrom(src => src.Customers.Surname))
                .ForMember(dto => dto.PhoneNumber, opt => opt.MapFrom(src => src.Customers.PhoneNumber))
                .ForMember(dto => dto.EmailAdres, opt => opt.MapFrom(src => src.Customers.EmailAdress))
                .ForMember(dto => dto.MaterialId, opt => opt.MapFrom(src => src.Materials.MaterialId))
                .ForMember(dto => dto.MaterialName, opt => opt.MapFrom(src => src.Materials.Name))
                .ForMember(dto => dto.MaterialDescription, opt => opt.MapFrom(src => src.Materials.Description))
                .ForMember(dto => dto.MaterialPrice, opt => opt.MapFrom(src => src.Materials.Price))
                .ForMember(dto => dto.ProductId, opt => opt.MapFrom(src => src.Products.ProductId))
                .ForMember(dto => dto.ProductName, opt => opt.MapFrom(src => src.Products.ProductName));
        
             CreateMap<Customer, OrderDto>()
                .ForMember(dto => dto.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                .ForMember(dto => dto.CustomerName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dto => dto.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dto => dto.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dto => dto.EmailAdres, opt => opt.MapFrom(src => src.EmailAdress));

            CreateMap<Material, OrderDto>()
               .ForMember(dto => dto.MaterialId, opt => opt.MapFrom(src => src.MaterialId))
               .ForMember(dto => dto.MaterialName, opt => opt.MapFrom(src => src.Name))
               .ForMember(dto => dto.MaterialDescription, opt => opt.MapFrom(src => src.Description))
                .ForMember(dto => dto.MaterialPrice, opt => opt.MapFrom(src => src.Price));

            CreateMap<Product, OrderDto>()
                .ForMember(dto => dto.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dto => dto.ProductName, opt => opt.MapFrom(src => src.ProductName))
                .ForMember(dto => dto.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dto => dto.ProductPrice, opt => opt.MapFrom(src => src.ProductPrice));
        }
    }
}

