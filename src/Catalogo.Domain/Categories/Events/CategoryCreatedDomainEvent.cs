using Catalogo.Domain.Abstractions;

namespace Catalogo.Domain.Categories.Events;

public sealed record CategoryCreatedDomainEvent(Guid categoryId): IDomainEvent;// o record é uma classe que é imutável por padrão, ou seja, uma vez que um objeto é criado, seus valores não podem ser alterados. Isso é útil para eventos de domínio, onde queremos garantir que os dados não sejam modificados após a criação do evento.