using Application.Dto;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
