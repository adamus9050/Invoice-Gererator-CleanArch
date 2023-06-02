using Application.Dto;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<CustomerDto, Customer>()
                .ForMember(e => e.Address, opt => opt.MapFrom(src => new Address()
                {
                    Street = src.Street,
                    NumberOf = src.NumberOf,
                    PostCode = src.PostCode,
                    City = src.City,

                }));           

            CreateMap<Customer, CustomerDto>()
                .ForMember(dto => dto.Street, opt => opt.MapFrom(src => src.Address.Street))
                .ForMember(dto => dto.NumberOf, opt => opt.MapFrom(src => src.Address.NumberOf))
                .ForMember(dto => dto.PostCode, opt => opt.MapFrom(src => src.Address.PostCode))
                .ForMember(dto => dto.City, opt => opt.MapFrom(src => src.Address.City));
            
            CreateMap<Address, CustomerDto>()
                .ForMember(dto => dto.Street, opt => opt.MapFrom(src => src.Street))
                .ForMember(dto => dto.NumberOf, opt => opt.MapFrom(src => src.NumberOf))
                .ForMember(dto => dto.PostCode, opt => opt.MapFrom(src => src.PostCode))
                .ForMember(dto => dto.City, opt => opt.MapFrom(src => src.City));
                
        }
    }
}
