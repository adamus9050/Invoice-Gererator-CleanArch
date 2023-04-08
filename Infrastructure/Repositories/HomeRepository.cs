using Application.Services;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class HomeRepository : IDataHomeService
    {
        private readonly DbCustContext _dbCustContext;
        public HomeRepository(DbCustContext dbCustContext)
        {
            _dbCustContext = dbCustContext;
        }

        public async Task SaveMaterials(Material material)
        {
            _dbCustContext.Materials.Add(material);

            if (_dbCustContext.SaveChanges() > 0)
            {
                Console.WriteLine("Udało się dodać matrial");
            }
            var idmaterial = $"l.p{material.Id} Nazwa: {material.Name} Cena: {material.Price}";
            // return idmaterial;
        }
    }
}
