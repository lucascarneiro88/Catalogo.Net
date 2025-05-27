using Catalogo.Domain.Abstractions;

namespace Catalogo.Domain.Products.Events;
public sealed record ProductCreatedDomainEvent(Guid id): IDomainEvent;// o record é uma classe que é imutável por padrão, ou seja,
//  uma vez que um objeto é criado, seus valores não podem ser alterados. 
//Isso é útil para eventos de domínio, onde queremos garantir que os dados não sejam modificados após a criação do evento.