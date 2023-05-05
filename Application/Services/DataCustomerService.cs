using Microsoft.EntityFrameworkCore;
using System.Data;
using Domain.Entities;
using Domain.Interfaces;
using Application.Dto;
using AutoMapper;

namespace Application.Services
{
    internal class DataCustomerService : IDataCustomerService
    {
        private readonly ICustomerRepository _dataBaseService;
        private readonly IMapper _mapper;
        public DataCustomerService(ICustomerRepository dataBaseService,IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task Save(CustomerDto customerdto)
        {
            //var customer=_mapper.Map<Domain.Entities.Customer>(customerdto);
            //await _dataBaseService.Save(customer);
        }

        public Address DeleteCustomers(int id)
        {
            _dataBaseService.DeleteCustomers(id);
            return DeleteCustomers(id);
        }

        public async Task<IEnumerable<CustomerDto>> GetAll()
        {
            //var customers=await _dataBaseService.GetAll();
            //var customerdto = _mapper.Map<IEnumerable<CustomerDto>>(customers);

            //return customerdto;
        }

        public Address GetAddress(int id)
        {
            _dataBaseService.GetAddress(id);
            return GetAddress(id);
        }

        public Task<List<Customer>> Search(string searchString)
        {
           var searchcustomer = _dataBaseService.Search(searchString);
            return searchcustomer;
        }
    }
}
