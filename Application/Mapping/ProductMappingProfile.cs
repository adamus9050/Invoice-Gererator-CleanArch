﻿using Application.Dto;
using AutoMapper;
using Domain.Entities;


namespace Application.Mapping
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductDto>()
                                .ForMember(dto => dto.ProductId, opt => opt.MapFrom(src => src.ProductId));

            CreateMap<ProductDto,Product >()
                                .ForMember(dto => dto.ProductId, opt => opt.MapFrom(src => src.ProductId));

        }
    }
}
