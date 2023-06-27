using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Domain.Interfaces;

namespace Infrastructure.Repositories
{
    internal class HomeRepository : IHomeRepository
    {
        private readonly DbCustContext _dbCustContext;
        public HomeRepository(DbCustContext dbCustContext)
        {
            _dbCustContext = dbCustContext;
        }

        public async Task SaveMaterials(Material material)
        {
             _dbCustContext.Materials.Add(material);

            if ( _dbCustContext.SaveChanges() > 0)
            {
                Console.WriteLine("Udało się dodać material");
            }
            var idmaterial = $"l.p{material.MaterialId} Nazwa: {material.Name} Cena: {material.Price}";
        }

        public async Task<Material> DeleteMaterial(int id)
        {

            //var idMat = _context.Materials.Where(x => x.Id == id).FirstOrDefault();
            var idMat =await _dbCustContext.Materials.FindAsync(id);
            _dbCustContext.Materials.Remove(idMat);
            _dbCustContext.SaveChanges();
            return idMat;
        }
        public async Task Commit()
        => _dbCustContext.SaveChangesAsync();
        public async Task<Material> GetMaterialById(int id)
        {
            var material = await _dbCustContext.Materials.FindAsync(id);
            return material;
        }
        public async Task<IEnumerable<Material>> GetAllMaterials()
        {
            var materials = await _dbCustContext.Materials.ToListAsync();
            return materials;
        }

        public async Task<List<Material>> SearchMaterial(string searchString)
        {
            var material = from m in _dbCustContext.Materials
                           select m;

            material = material.Where(x => x.Name!.Contains(searchString) || x.Price!.ToString().Contains(searchString));

            var result = await material.ToListAsync();
            return result;
        }


    }
}
