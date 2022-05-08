using ListaLeitura.App.Logica;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace ListaLeitura.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            /* Com esse comando as rotas vão ser lidas no padrão /{Controller}/{Action} 
             * O ASP NET irá ler as classes terminadas em Controller.cs e as actions são as funções
             * 
             */
            app.UseMvcWithDefaultRoute();

            app.UseDeveloperExceptionPage();
        }

    }
}