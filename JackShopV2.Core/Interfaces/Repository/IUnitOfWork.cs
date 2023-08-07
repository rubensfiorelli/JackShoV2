namespace JackShopV2.Core.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        Task<bool> CommitAsync();
        Task Rollback();
    }
}
