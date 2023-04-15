using Domain.Entities;
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
        private readonly IHomeRepository _dataBaseService;
        public DataHomeService(IHomeRepository dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        public async Task SaveMaterials(Material material)
        {
            await _dataBaseService.SaveMaterials(material);
        }
        public async Task DeleteMaterial(int id)
        {
            await _dataBaseService.DeleteMaterial(id);
        }

        public IEnumerable<Material> GetAllMaterials()
        {
           IEnumerable<Material> materials= _dataBaseService.GetAllMaterials();
            return materials;
        }
    }
}
