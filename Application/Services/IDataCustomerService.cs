using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;


namespace Application.Services
{
    public interface IDataCustomerService
    {
        Task Save(Customer customer);
    }
}