using Application.Dto;
using Domain.Entities;
using AutoMapper;
using Application.Dto.Material.MaterialCommand.Edit;

namespace Application.Mapping
{
    public class MaterialMappingProfile : Profile
    {
        public MaterialMappingProfile()
        {
            CreateMap<MaterialDto, Material>()
                .ForMember(dto => dto.MaterialId, opt => opt.MapFrom(src => src.Id));

            CreateMap<Material, MaterialDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(src => src.MaterialId));

            CreateMap<MaterialDto, EditMaterialCommand>();

        }
    }
}

