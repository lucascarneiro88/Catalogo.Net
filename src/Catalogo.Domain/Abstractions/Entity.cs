namespace Catalogo.Domain.Abstractions;

//toda a classe entidade vai ter um atributo em comum que vai ser i id;
//todas as classes que herdam de Entity vão ter um id e vão poder agregar eventos de dominio

public abstract class Entity
{


    //criando coleção que manuseie(manipule) os eventos de dominio
    private readonly List<IDomainEvent> _domainEvents = new();
    public Guid Id { get; init; }//init serve para iniciar uma propriedade apenas uma vez, no construtor ou na inicialização do objeto.


    //construtor
    //construtor, no momento em que eu quiser criar um novo objeto entidade vai ser passado como parametro este id que tem o objeto
    protected Entity(Guid id)
    {
        Id = id;//injetando valor do id atraves do construtor
    }


    //metodo para devolver todos os eventos armazenados na lista _domainEvents
    public IReadOnlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.ToList(); //retorna uma cópia da lista de eventos de domínio como uma lista somente leitura
    }

    //metodo void para limpar os eventos de dominio
    public void ClearDomainEvents()
    {
        _domainEvents.Clear(); //limpa a lista de eventos de domínio
    }

    //metodo que permite adicionar novas notificações a lista de eventos de dominio
    public void RaiseDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent); //adiciona o evento de domínio à lista de eventos de domínio
                                        //o evento de dominio é um objeto que implementa a interface IDomainEvent
                                        //o domain event é um objeto que representa algo que aconteceu no dominio da aplicação, e que pode ser tratado por outros componentes do sistema
                                        //o domain event é um objeto que representa uma ação ou um acontecimento que ocorreu em um determinado contexto do domínio da aplicação.
    }
}
