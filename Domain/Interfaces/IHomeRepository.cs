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
        Task<Material> DeleteMaterial(int id);
        Task <IEnumerable<Material>> GetAllMaterials();
        Task <Material> GetMaterialById(int id);
        Task Commit();
        Task<List<Material>> SearchMaterial(string searchString);
    }
}
