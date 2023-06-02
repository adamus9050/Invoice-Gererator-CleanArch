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

        public Task<List<Customer>> Search(string searchString)
        {
           var searchcustomer = _dataBaseService.Search(searchString);
            return searchcustomer;
        }
    }
}
