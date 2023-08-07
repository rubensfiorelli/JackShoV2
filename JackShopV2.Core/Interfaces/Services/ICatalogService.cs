using JackShopV2.Core.ViewModels;

namespace JackShopV2.Application.Interfaces.Services
{
    public interface ICatalogService
    {
        Task<List<OrderViewModel>> GetAll();
    }
}
