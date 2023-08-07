using JackShopV2.Core.Entities;
using JackShopV2.Core.Interfaces.Repository;
using JackShopV2.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace JackShopV2.Infrastructure.Repositories
{
    public class CatalogRepository : ICatalogRepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<Catalog> _catalogSet;

        public CatalogRepository(ApplicationDbContext context)
        {
            _context = context;
            _catalogSet = context.Set<Catalog>();
        }

        public async Task<List<Catalog>> GetAllAsync()
        {
            try
            {
                return await _catalogSet
                    .Take(20)
                    .ToListAsync();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
