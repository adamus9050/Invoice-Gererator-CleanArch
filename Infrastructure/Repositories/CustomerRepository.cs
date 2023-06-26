using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public async Task Save(Address customer)
        {
            //customer.CreatedAt = DateTime.Now;
            _context.Addresses.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<Customer> DeleteCustomers(int id)
        {
            var idDel = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(idDel);
            _context.SaveChanges();
            return idDel; 
        }

        public async Task<Address> GetAddress(int id) 
        {
            var address = await _context.Addresses.FindAsync(id); 
            return address;

            //var address = await _context.Addresses.FirstAsync(c => c.AddressId == id+1);
            //return address;

        }
        public async Task<Customer> GetCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
                    //await _context.Addresses.FirstAsync(src => src.AddressId == id);

            return customer;
        }
        

        public Task Commit()
            => _context.SaveChangesAsync();

        public async Task<IEnumerable<Customer>> GetAll()
        {
            var klient=await _context.Customers.ToListAsync();
            return klient;
  
        }

        public async Task<List<Customer>> Search(string searchString)
        {
            var customer = from m in _context.Customers
                           select m;

            customer = customer.Where(x => x.Name!.Contains(searchString) || x.Surname!.Contains(searchString) || x.PhoneNumber!.Contains(searchString));

            var zmienna = await customer.ToListAsync();
            return zmienna;
        }
    }
}

