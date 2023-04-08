using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    internal interface IHomeRepository
    {
        Task SaveMaterials(Material material);
        //IEnumerable<Material> GetAllMaterials();
        //Material DeleteMaterial(int id);
        //Task<List<Material>> SearchMaterial(string searchString);
    }
}
