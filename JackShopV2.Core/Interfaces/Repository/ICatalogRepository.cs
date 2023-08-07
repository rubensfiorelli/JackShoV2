using JackShopV2.Core.Entities;

namespace JackShopV2.Core.Interfaces.Repository
{
    public interface ICatalogRepository
    {
        Task<List<Catalog>> GetAllAsync();

    }
}
