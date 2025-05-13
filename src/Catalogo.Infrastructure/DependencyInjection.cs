using Catalogo.Domain.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore; // Necessário para AddDbContext e UseSqlite
using Microsoft.Extensions.Logging;  // Necessário para LogLevel e DbLoggerCategory



namespace Catalogo.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(//metodo de extensão
        this IServiceCollection services,// referencia para o serviço
        IConfiguration configuration// referencia para a configuração
    )

    {
        services.AddDbContext<CatalogoDbContext>(opt => {
            opt.LogTo(Console.WriteLine, new[] {
                DbLoggerCategory.Database.Command.Name
            }, LogLevel.Information).EnableSensitiveDataLogging();
            

            opt.UseSqlite(
                configuration.GetConnectionString("SqliteProduct")
            ).UseSnakeCaseNamingConvention();
            
            });
        return services;
    }


}