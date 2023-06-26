using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProductRepository
    {
        Task <IEnumerable<Product>> ProducList();
        Task AddProduct(Product product);
        Task<List<Product>> SearchProduct(string searchString);
        Task<Product> GetProductById(int id);
        Task Commit();

    }
}
