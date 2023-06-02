using Application.Dto;
using Domain.Entities;
using AutoMapper;

namespace Application.Mapping
{
    public class MaterialMappingProfile : Profile
    {
        public MaterialMappingProfile()
        {
            CreateMap<Material, MaterialDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dto => dto.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dto => dto.Description, opt => opt.MapFrom(src => src.Description));

        }
    }
}
