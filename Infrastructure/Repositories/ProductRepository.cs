using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbCustContext _context;
        public ProductRepository(DbCustContext context) {
            _context= context;
        }

        public async Task<IEnumerable<Product>> ProducList()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }

        public async Task AddProduct(Product prd)
        {
            var product = await _context.Products.AddAsync(prd);
            _context.SaveChanges();
            var productProp = $"{prd.ProductName},{prd.ProductPrice},{prd.Type}";
        }

            public async Task Commit()
            => _context.SaveChangesAsync();

        public async Task<Material> GetMaterialById(int id)
        {
            var material = await _context.Materials.FindAsync(id);
            return material;
        }

        public async Task<List<Product>> SearchProduct(string searchString)
        {
            var product = from m in _context.Products
                           select m;

            product = product.Where(x => x.ProductName!.Contains(searchString) || x.ProductPrice!.ToString().Contains(searchString) || x.Type!.ToString().Contains(searchString));

            var result = await product.ToListAsync();
            return result;
        }

        public async Task<Product> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            return product;
        }
    }
}
