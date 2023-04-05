using Microsoft.EntityFrameworkCore;
using System.Data;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    internal class DatabseService
    {
        private readonly IDataBaseService _dataBaseService;
        public DatabseService(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;            
        }
        public async Task Save(Customer customer)
        {
            await _dataBaseService.Save(customer);
        }
    }
}
