using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;


namespace Application.Services
{
    public interface IDataCustomerService
    {
        Task Save(Customer customer);
        Address DeleteCustomers(int id);
        IEnumerable<Customer> GetAll();
        Address GetAddress(int id);
    }
}