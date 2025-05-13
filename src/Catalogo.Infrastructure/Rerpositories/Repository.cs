using Microsoft.EntityFrameworkCore;
using Catalogo.Domain.Abstractions;
using Catalogo.Domain.Infrastructure;

namespace Catlogo.Infrastructure.Repositories; 

// Classe abstrata genérica que define um repositório base para qualquer entidade que herde de Entity
internal abstract class Repository<T> where T : Entity
{
    // Instância protegida do DbContext usada pelas classes filhas para acessar o banco
    protected readonly CatalogoDbContext dbContext;

    // Construtor que recebe o contexto e inicializa a variável local
    protected Repository(CatalogoDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    // Método assíncrono para buscar uma entidade pelo seu Id
    // Usa LINQ para filtrar o dado e retorna o primeiro resultado ou null
    public async Task<T?> GetIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await dbContext.Set<T>() // Acessa o DbSet da entidade T
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken); // Busca o primeiro que corresponde ao Id
    }

    // Método síncrono para adicionar uma nova entidade ao DbContext
    // A mudança só será persistida no banco após chamar SaveChangesAsync()
    public void Add(T entity)
    {
        dbContext.Add(entity);
    }
}
