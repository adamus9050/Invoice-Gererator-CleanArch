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
        Task Save(Customer customer);
        Task<Customer> DeleteCustomers(int id);
        Task<IEnumerable<Customer>> GetAll();
        Task <Address> GetAddress(int id); //Task<Customer>

        Task<List<Customer>> Search(string searchString);
        //Task<List<Material>> SearchMaterial(string searchString);
    }
}
