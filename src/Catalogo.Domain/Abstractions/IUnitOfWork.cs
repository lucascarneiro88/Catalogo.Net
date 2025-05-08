namespace Catalogo.Domain.Abstractions;

public interface IUnitOfWork
{
    //metodo assincrono que vai devolver um valor numerico,
    //o valor numerico vai ser o numero de registros que foram alterados no banco de dados 
    //o int representa este caso o numero de registros que foram alterados no banco de dados
    //o cancellationToken é um token que pode ser usado para cancelar a operação assíncrona
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}