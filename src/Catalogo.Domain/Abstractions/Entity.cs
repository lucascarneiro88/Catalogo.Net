namespace Catalogo.Domain.Abstractions;

public abstract class Entity 
{

public Guid Id { get; init;}//init serve para iniciar uma propriedade apenas uma vez, no construtor ou na inicialização do objeto.


//construtor
//construtor, no momento em que eu quiser criar um novo objeto entidade vai ser passado como parametro este id que tem o objeto
protected Entity(Guid id)
{
    Id = id;//injetando valor do id atraves do construtor
}

}