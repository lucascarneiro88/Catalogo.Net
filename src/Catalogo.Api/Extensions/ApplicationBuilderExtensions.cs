
using Catalogo.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Api.Extensins;

public static class ApplicationBuilderExtensions
{
    public static async Task ApplyMigration(this IApplicationBuilder app)// metodo de extensao
    {
        using (var scope = app.ApplicationServices.CreateScope())
        {
            var service = scope.ServiceProvider;// cria um escopo para o serviço
            var loggerFactory = service.GetRequiredService<ILoggerFactory>();// cria um logger para o serviço


            try
            {
                var context = service.GetRequiredService<CatalogoDbContext>();// cria um contexto para o banco de dados
                await context.Database.MigrateAsync();
            }
            catch (Exception ex)// captura a exceção
            {
                var logger = loggerFactory.CreateLogger<Program>();// cria um logger para o programa
                logger.LogError(ex, "Error in apply migration");// loga o erro
            }

        }
    }
}