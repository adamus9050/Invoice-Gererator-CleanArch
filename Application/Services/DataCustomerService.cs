using Microsoft.EntityFrameworkCore;
using System.Data;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    internal class DataCustomerService : IDataCustomerService
    {
        private readonly ICustomerRepository _dataBaseService;
        public DataCustomerService(ICustomerRepository dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        public async Task Save(Customer customer)
        {
            await _dataBaseService.Save(customer);
        }

        public Address DeleteCustomers(int id)
        {
            _dataBaseService.DeleteCustomers(id);
            return DeleteCustomers(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            _dataBaseService.GetAll();
            return GetAll();
        }

        public Address GetAddress(int id)
        {
            _dataBaseService.GetAddress(id);
            return GetAddress(id);
        }
    }
}
