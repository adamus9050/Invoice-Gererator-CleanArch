using Application.Dto;
using Application.Dto.Material.MaterialCommand.Edit;
using Application.Dto.Product.ProductCommand.Edit;
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

            CreateMap<ProductDto, EditProductCommand>();


        }
    }
}
