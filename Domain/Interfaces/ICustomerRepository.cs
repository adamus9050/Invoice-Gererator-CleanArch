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
        Address DeleteCustomers(int id);
        IEnumerable<Customer> GetAll();
        Address GetAddress(int id);

        //Task<List<Customer>> Search(string searchString);
        //Task<List<Material>> SearchMaterial(string searchString);
    }
}
