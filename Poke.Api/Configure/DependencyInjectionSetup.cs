using Microsoft.Extensions.DependencyInjection;
using Poke.Data;
using Poke.Data.Interfaces;
using Poke.Services;
using Poke.Services.Interfaces;
using System;

namespace Poke.Api.Configure
{
    public static class DependencyInjectionSetup
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            #region repositorios

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            #endregion repositorios

            #region servicos

            services.AddTransient<IUsuarioServices, UsuarioServices>();

            #endregion servicos
        }
    }
}