using Domain.Entities;

namespace Application.Services
{
    public interface IDataHomeService
    {
        Task SaveMaterials(Material material);
        //IEnumerable<Material> GetAllMaterials();
        //Material DeleteMaterial(int id);
        //Task<List<Material>> SearchMaterial(string searchString);

    }
}