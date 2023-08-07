using JackShopV2.Core.InputModels;
using JackShopV2.Core.ViewModels;

namespace JackShopV2.Application.Interfaces.Services
{
    public interface IOrderService
    {
        Task<string> Add(OrderInputModel model);
        Task<OrderViewModel> GetTrackingCode(string trackingCode);
    }
}
