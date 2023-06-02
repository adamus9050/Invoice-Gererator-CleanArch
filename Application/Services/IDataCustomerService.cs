using Application.Dto;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;


namespace Application.Services
{
    public interface IDataCustomerService
    {
        Task<List<Customer>> Search(string searchString);
    }
}