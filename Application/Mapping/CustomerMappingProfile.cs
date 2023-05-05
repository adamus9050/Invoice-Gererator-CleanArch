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

                
                
        }
    }
}
