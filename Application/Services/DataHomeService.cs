using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    internal class DataHomeService : IDataHomeService
    {
        private readonly ICustomerRepository _dataBaseService;
        public DataHomeService(ICustomerRepository dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

    }
}
