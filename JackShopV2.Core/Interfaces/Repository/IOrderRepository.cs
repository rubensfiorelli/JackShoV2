using JackShopV2.Core.Entities;

namespace JackShopV2.Core.Interfaces.Repository
{
    public interface IOrderRepository : IUnitOfWork
    {
        Task<Order> GetCodeAsync(string code);
        Task AddAsync(Order order);

    }
}
