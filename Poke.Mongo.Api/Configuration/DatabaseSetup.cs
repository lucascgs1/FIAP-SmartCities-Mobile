using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Poke.Mongo.Api.Models;
using Poke.Mongo.Api.Services;

namespace Poke.Mongo.Api.Configuration
{
    public static class DatabaseSetup
    {
        public static void AddDatabaseSetup(this IServiceCollection services, IConfiguration configuration)
        {
            // requires using Microsoft.Extensions.Options
            services.Configure<PokeDatabaseSettings>(configuration.GetSection(nameof(PokeDatabaseSettings)));

            services.AddSingleton<IPokeDatabaseSettings>(sp => sp.GetRequiredService<IOptions<PokeDatabaseSettings>>().Value);

            services.AddSingleton<ParadaService>();
            services.AddSingleton<UsuarioService>();
            services.AddSingleton<VeiculoService>();
        }
    }
}