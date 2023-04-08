using Application.Services;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Console.WriteLine("Udało się dodać matrial");
            }
            var idmaterial = $"l.p{material.Id} Nazwa: {material.Name} Cena: {material.Price}";
            // return idmaterial;
        }

        public async Task DeleteMaterial(int id)
        {

            //var idMat = _context.Materials.Where(x => x.Id == id).FirstOrDefault();
            Material idMat = _dbCustContext.Materials.Find(id);
            _dbCustContext.Materials.Remove(idMat);
            _dbCustContext.SaveChanges();
            //return idMat;
        }

        public IEnumerable<Material> GetAllMaterials()
        {
            var materials = _dbCustContext.Materials.ToList();
            return materials;
        }

        //    public async Task<List<Material>> SearchMaterial(string searchString)
        //    {
        //        var material = from m in _context.Materials
        //                       select m;

        //        material = material.Where(x => x.Name!.Contains(searchString) || x.Price!.ToString().Contains(searchString));

        //        var zmienna1 = await material.ToListAsync();
        //        return zmienna1;
        //    }


    }
}
