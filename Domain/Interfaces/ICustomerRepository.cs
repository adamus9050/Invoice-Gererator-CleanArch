using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task Save(Address customer);
        Task<Customer> DeleteCustomers(int id);
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer> GetCustomer(int id);
        Task <Address> GetAddress(int id);//Address
        //Task<Address> Edit(int id);
        Task Commit();
        Task<List<Customer>> Search(string searchString);
        //Task<List<Material>> SearchMaterial(string searchString);
    }
}
