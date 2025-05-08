using Microsoft.EntityFrameworkCore;

namespace Catalogo.Domain.Infrastructure;


public sealed class CatalogoDbContext : DbContext // referencia para persintencia de dados
{
 public CatalogoDbContext(DbContextOptions options) : base(options)// o options representa a conexão com o banco de dados
 {

 }


protected override void OnModelCreating(ModelBuilder builder)// metodo para criar o modelo do banco de dados
 {
    builder.ApplyConfigurationsFromAssembly(typeof(CatalogoDbContext).Assembly);// aplica as configurações do assembly atual no modelo do banco de dados
    base.OnModelCreating(builder);// chama o metodo base para criar o modelo do banco de dados


 }




}