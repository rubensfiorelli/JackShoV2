using JackShopV2.Core.Entities;
using JackShopV2.Core.Interfaces.Repository;
using JackShopV2.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace JackShopV2.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<Order> _catalogOrders;
        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
            _catalogOrders = context.Set<Order>();
        }


        public async Task AddAsync(Order order)
        {
            try
            {

                using (_context)
                {
                    var seek = await _catalogOrders.FirstOrDefaultAsync(c => c.Id.Equals(order.Id));

                    order.CreateAt = DateTime.Now;
                    _catalogOrders.Add(order);
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Order> GetCodeAsync(string code)
        {
            try
            {
                using (_context)
                {
                    return await _catalogOrders.FirstOrDefaultAsync(c => c.TrackingCode.Equals(code));
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> CommitAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public Task Rollback()
        {
            return Task.CompletedTask;
        }
    }
}
