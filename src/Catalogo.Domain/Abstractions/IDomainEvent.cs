using MediatR;

namespace Catalogo.Domain.Abstractions;


public interface IDomainEvent : INotification // a interface IDomain implemnta interface INotification do MediatR
 // o MediatR é uma biblioteca que implementa o padrão Mediator, que é um padrão de design que promove a separação de responsabilidades e a comunicação entre objetos sem que eles precisem se conhecer diretamente.
 // esse evento vai trabalhar quando necessitar criar uma instancia de um objeto e nesse momento se eu quiser que despare em certas circustancias um domain event
 //cada vez que registrar um usuario tambem pode  disparar um evento que envie um correio eletronico ao usuario

 
 
 {

 }