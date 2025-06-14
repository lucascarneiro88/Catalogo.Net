using Catalogo.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Infrastructure.Repositories;

internal sealed class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(CatalogoDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Product>> GetAll(CancellationToken cancellationToken)
    {
       return await dbContext.Set<Product>().ToListAsync(cancellationToken);
    }

    public async Task<Product?> GetByCode(string code, CancellationToken cancellationToken)
    {
       return await dbContext
                    .Set<Product>()
                    .Where(x => x.Code == code)
                    .FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<Product?> GetIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await dbContext
                     .Set<Product>()
                     .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }
}
