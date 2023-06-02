using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IHomeRepository
    {
        Task SaveMaterials(Material material);
        Task DeleteMaterial(int id);
        IEnumerable<Material> GetAllMaterials();

        Task<List<Material>> SearchMaterial(string searchString);
    }
}
