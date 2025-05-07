using System.Runtime.CompilerServices;
using Catalogo.Domain.Abstractions;
using Catalogo.Domain.Categories.Events;

namespace Catalogo.Domain.Categories;
public class Category : Entity 

{

//Atribucto
public string? Name { get; private set;}

//constructor
private Category (Guid id, string name) : base(id)
{
    Name = name; //injetando valor do name atraves do construtor
}


//metodo que cria uma nova categoria
public static Category Create(string name)
{
var category = new Category(Guid.NewGuid(), name);//gerando um novo id para a categoria
var categoryDomainEvent = new CategoryCreatedDomainEvent(category.Id);//criando um novo evento de dominio
category.RaiseDomainEvent(categoryDomainEvent);
return category;
}
}




//herda da classe Entity, que é a classe base para todas as entidades do domínio
//a classe Category representa uma categoria de produtos ou serviços no sistema
//ela é uma entidade, o que significa que ela tem uma identidade única (Id) e pode ter eventos de domínio associados a ela

// Atribucto: private set servira para encapsular a data de persisntencia que se maneja sobre os atributos da classe Category
// o private set significa que a propriedade pode ser lida fora da classe, mas só pode ser modificada dentro da classe

//constructor: necessario o construtor da classe Category receber um Guid id como parâmetro e chama o construtor da classe base Entity com esse id

//isso garante que cada instância da classe Category tenha um id único e que possa agregar eventos de domínio