namespace Catalogo.Domain.Categories;

// Interface que define o contrato para operações com a entidade Category
// É usada para abstrair o acesso ao repositório de categorias
public interface ICategoryRepository
{
    // Método assíncrono que retorna uma lista com todas as categorias cadastradas
    Task<List<Category>> GetAll();

    // Método que adiciona uma nova categoria ao contexto do banco
    // O salvamento definitivo é feito posteriormente com SaveChangesAsync()
    void Add(Category category);

    // Método assíncrono que busca uma categoria específica pelo seu Id (Guid)
    // O CancellationToken permite cancelar a operação se necessário (por exemplo, se o usuário encerrar a requisição)
    Task<Category> GetIdAsync(Guid id, CancellationToken cancellationToken);
}
