namespace Catalogo.Domain.Categories;

public interface ICategoryRepository
{
    //metodo para devolver todas as categorias
    Task<List<Category>> GetAll();//task assincrono, para buscar a lista de categorias
    void Add(Category category);//metodo para adicionar uma categoria
}

//aqui só implementa o que vai fazer a aplicação, como vai fazer sera implemntado na camada de infra