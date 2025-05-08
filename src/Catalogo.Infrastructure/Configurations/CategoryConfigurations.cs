using Catalogo.Domain.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalogo.Domain.Infrastructure.Configurations;

//metodo de configuração da entidade Category no banco de dados
internal sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>// classe que implementa a interface IEntityTypeConfiguration para configurar a entidade Category no banco de dados
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("categories");// nome da tabela no banco de dados
        builder.HasKey(c => c.Id);//função lambda que define a chave primaria da tabela, neste caso a chave primaria é o Id da categoria
    }
}

