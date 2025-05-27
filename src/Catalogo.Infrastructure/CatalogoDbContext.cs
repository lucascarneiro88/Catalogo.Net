using Catalogo.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Infrastructure;

public sealed class CatalogoDbContext : DbContext, IUnitOfWork
{
    public CatalogoDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(CatalogoDbContext).Assembly);
        base.OnModelCreating(builder);
    }

    public override async Task<int> SaveChangesAsync(
        CancellationToken cancellationToken=default
    )
    {
        var results = await base.SaveChangesAsync(cancellationToken);
        return results;
    }


}