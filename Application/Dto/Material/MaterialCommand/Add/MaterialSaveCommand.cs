using MediatR;
using System;
using Domain.Entities;
using Application.Dto.Material;
using Application.Dto;

namespace Application.Dto.Material.MaterialCommand.Add
{
    public class MaterialSaveCommand : MaterialDto, IRequest<Unit>
    {

    }
}
