using System;
using Domain.Entities;
using Application.Dto.Material;
using Application.Dto;
using MediatR;


namespace Application.Dto.Product.ProductCommand.Add
{
    public class AddProductCommand : ProductDto , IRequest<Unit> 
    {

    }
}
