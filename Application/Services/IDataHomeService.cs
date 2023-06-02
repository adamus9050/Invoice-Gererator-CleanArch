using Domain.Entities;

namespace Application.Services
{
    public interface IDataHomeService
    {
        //Task SaveMaterials(Material material);
        //Task DeleteMaterial(int id);
        //IEnumerable<Material> GetAllMaterials();

        Task<List<Material>> SearchMaterial(string searchString);

    }
}