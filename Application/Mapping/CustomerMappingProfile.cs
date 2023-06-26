using Application.Dto;
using Application.Dto.Customer.Command.Edit;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<CustomerDto, Address>()
                .ForMember(e => e.CurrentCustomer, opt => opt.MapFrom(src => new Customer()
                {
                    CustomerId=src.Id,
                    Name = src.Name,
                    Surname = src.Surname,
                    PhoneNumber = src.PhoneNumber,
                    EmailAdress = src.EmailAdres,

                }));
            

            CreateMap<Address, CustomerDto>()       
                .ForMember(dto => dto.Id, opt => opt.MapFrom(src => src.CurrentCustomer.CustomerId))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(src => src.CurrentCustomer.Name))
                .ForMember(dto => dto.Surname, opt => opt.MapFrom(src => src.CurrentCustomer.Surname))
                .ForMember(dto => dto.PhoneNumber, opt => opt.MapFrom(src => src.CurrentCustomer.PhoneNumber))
                .ForMember(dto => dto.EmailAdres, opt => opt.MapFrom(src => src.CurrentCustomer.EmailAdress));

            CreateMap<Customer, CustomerDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(src => src.CustomerId))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dto => dto.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dto => dto.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dto => dto.EmailAdres, opt => opt.MapFrom(src => src.EmailAdress));


            CreateMap<CustomerDto, EditCustomerCommand>();
        }
    }
}
