using Application.Dto;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;


namespace Application.Services
{
    public interface IDataCustomerService
    {
        Task Save(CustomerDto customer);
        Address DeleteCustomers(int id);
        Task<IEnumerable<CustomerDto>> GetAll();
        Address GetAddress(int id);
        Task<List<Customer>> Search(string searchString);
    }
}