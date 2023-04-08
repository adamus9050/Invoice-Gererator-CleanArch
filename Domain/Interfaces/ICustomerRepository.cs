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
        //IEnumerable<Customer> GetAll();
        //Address Get(int id);
        //Address DeleteCustomers(int id);
        //Material DeleteMaterial(int id);
        //Task<List<Customer>> Search(string searchString);
        //Task<List<Material>> SearchMaterial(string searchString);
    }
}
