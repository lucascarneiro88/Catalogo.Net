using Catalogo.Domain.Abstractions;
using Catalogo.Domain.Products.Events;

namespace Catologo.Domain.Products;


public sealed class Product : Entity
{


    public string? Name { get; set; }
    public decimal? Price { get; set; }

    public string? Description { get; set; }
    public string? ImageUrl { get; set; }

    public string? Code { get; set; }

    public Guid CategoryId { get; set; }


    //constructor
    private Product(
        Guid id,
        string name,
        decimal price,
        string description,
        string imageUrl,
        string code,
        Guid categoriId
    ) : base(id)
    {
        Name = name;
        Price = price;
        Description = description;
        ImageUrl = imageUrl;
        Code = code;
        CategoryId = categoriId;
    }


    //metodo publico do tipo statico para novo objeto produto
    public static Product Create(
        string name,
        decimal price,
        string description,
        string imageUrl,
        string code,
        Guid categoryId

    )
    {
        var product = new Product(
            Guid.NewGuid(),
            name,
            price,
            description,
            imageUrl,
            code,
            categoryId
        );//bloco para inicializar o produto

        var productDomainEvent = new ProductCreatedDomainEvent(product.Id);
        //chamara notificacao de produto criado
        product.RaiseDomainEvent(productDomainEvent);
        return product;
    }




}