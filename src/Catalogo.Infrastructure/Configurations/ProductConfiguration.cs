using Catalogo.Domain.Categories;
using Catalogo.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalogo.Infrastructure.Configurations;

internal class ProductConfiguration : IEntityTypeConfiguration<Product>// classe que implementa a interface IEntityTypeConfiguration para configurar a entidade Product no banco de dados
{

    //metodo de configuração da entidade Product no banco de dados
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("products");
        builder.HasKey(p => p.Id);//função lambda que define a chave primaria da tabela, neste caso a chave primaria é o Id do produto

        builder.HasOne<Category>()//define o relacionamento entre produto e categoria onde um produto tem uma categoria
            .WithMany()
            .HasForeignKey(c => c.CategoryId); //define que uma categoria pode ter muitos produtos


    }
}