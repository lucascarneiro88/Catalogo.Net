using Catologo.Domain.Products;

namespace Catalogo.Domain.Products;

// Interface que define o contrato para repositório de produtos
// Ela obriga qualquer classe que a implemente a fornecer essas funcionalidades
public interface IProductRepository
{
    // Método assíncrono que busca um produto com base em um código único
    // Pode ser ID, código de barras, SKU, etc.
    Task<Product> GetByCode(string code);

    // Método assíncrono que retorna uma lista com todos os produtos cadastrados
    Task<List<Product>> GetAll();

    // Método para adicionar um novo produto ao repositório
    // Ainda não salva no banco — isso será feito no SaveChangesAsync()
    void Add(Product product);

    // Método assíncrono que busca um produto pelo seu Id (Guid)
    // Recebe um CancellationToken para permitir cancelamento da operação, se necessário
    Task<Product> GetIdAsync(Guid id, CancellationToken cancellationToken);
}