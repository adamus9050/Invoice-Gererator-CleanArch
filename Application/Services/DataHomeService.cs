using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class DataHomeService : IDataHomeService
    {
        private readonly IHomeRepository _dataBaseService;
        private readonly IMapper _mapper;
        public DataHomeService(IHomeRepository dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public Task<List<Material>> SearchMaterial(string searchString)
        {
            var searchmaterial = _dataBaseService.SearchMaterial(searchString);
            return searchmaterial;
        }
    }
}
