using Catalogo.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Domain.Infrastructure;


public sealed class CatalogoDbContext : DbContext, IUnitOfWork//classe que representa o contexto do banco de dados, herda de DbContext e IUnitOfWork
// IUnitOfWork é uma interface que define um contrato para a unidade de trabalho, que é um padrão de design usado
{
    public CatalogoDbContext(DbContextOptions options) : base(options)// o options representa a conexão com o banco de dados
    {

    }


    protected override void OnModelCreating(ModelBuilder builder)// metodo para criar o modelo do banco de dados
    {
        builder.ApplyConfigurationsFromAssembly(typeof(CatalogoDbContext).Assembly);// aplica as configurações do assembly atual no modelo do banco de dados
        base.OnModelCreating(builder);// chama o metodo base para criar o modelo do banco de dados


    }

    public override async Task<int> SaveChangesAsync(
        CancellationToken cancellationToken = default
        )
    {
        var results = await base.SaveChangesAsync(cancellationToken);
        return results;
    }



}