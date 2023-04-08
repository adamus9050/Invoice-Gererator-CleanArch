using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class CustomerRepository : ICustomerRepository
    {

        private readonly DbCustContext _context;
        public CustomerRepository(DbCustContext dbContext)
        {
            _context = dbContext;
        }
        public async Task Save(Customer customer)
        {
            _context.Customers.Add(customer);

            if (await _context.SaveChangesAsync() > 0)
            {
                Console.WriteLine("Udało się dodać klienta");
            };

           // return customer.Id;
        }

        public Address DeleteCustomers(int id)
        {
            Address idDel = _context.Addresses.Find(id);
            _context.Addresses.Remove(idDel);
            _context.SaveChanges();
            return idDel;
        }

        public Address GetAddress(int id)
        {

            var address = _context.Addresses.Find(id);
            return address;
        }

        public IEnumerable<Customer> GetAll()
        {
            var klient = _context.Customers.ToList();
            return klient;
        }



        //    public async Task<List<Customer>> Search(string searchString)
        //    {
        //        var customer = from m in _context.Customers
        //                       select m;

        //        customer = customer.Where(x => x.Name!.Contains(searchString) || x.Surname!.Contains(searchString) || x.PhoneNumber!.Contains(searchString));

        //        var zmienna = await customer.ToListAsync();
        //        return zmienna;
        //    }

    }
}

