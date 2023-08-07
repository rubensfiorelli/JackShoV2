using JackShopV2.Application.Interfaces.Services;
using JackShopV2.Core.InputModels;
using JackShopV2.Core.Interfaces.Repository;
using JackShopV2.Core.ViewModels;

namespace JackShopV2.Application.Services
{
    public class OrderService : IOrderService
    {
        protected readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }


        public async Task<string> Add(OrderInputModel model)
        {
            var order = model.ToEntity();

            var catalog = model
                .Products
                .Select(s => s.ToEntity())
                .ToList();


            order.SetupOrders(catalog);

            await _repository.AddAsync(order);

            return order.TrackingCode;

        }


        public async Task<OrderViewModel> GetTrackingCode(string trackingCode)
        {
            var order = await _repository.GetCodeAsync(trackingCode);

            return OrderViewModel.FromEntity(order);
        }


    }
}
