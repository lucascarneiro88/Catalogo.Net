using Catologo.Domain.Products;

namespace Catalogo.Domain.Products;

public interface IProductRepository
{
    //metodo para buscar produto pelo codigo(id, codigo de barras, sku,  etc)
    Task<Product> GetByCode(string code);
    Task<List<Product>> GetAll();//metodo para buscar lista de todos produtos
}