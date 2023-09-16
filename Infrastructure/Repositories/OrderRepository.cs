using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DbCustContext _context;
        public OrderRepository(DbCustContext dbCustContext)
        {
            _context = dbCustContext;
        }


        public async Task Save(Order productMaterialCustomer)
        {
            _context.Orders.Add(productMaterialCustomer);

            foreach (var order in _context.Orders) 
            {
                var orderDetail = new Order()
                {
                    CustomersId = order.CustomersId,
                    MaterialsId = order.MaterialsId,
                    ProductId = order.ProductId,

                };
                _context.Orders.Add(orderDetail);
            }
            _context.SaveChanges();
        }
        public async Task<IEnumerable<Order>> GetAll()
        {
            var orderList = await _context.Orders.ToListAsync();
            return orderList;
        }
    }
}
