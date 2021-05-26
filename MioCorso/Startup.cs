using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MioCorso
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsEnvironment("Development"))
            {
              app.UseDeveloperExceptionPage(); // middleware che agisce in caso di eccezione in development
            }

          app.UseStaticFiles(); // middleware che permette di fornire File Statici

          
            app.UseRouting();  

            app.UseEndpoints(endpoints =>    // middleware che restituisce risposta html
            {
                endpoints.MapGet("/", async context =>
                {
                    String nome = context.Request.Query["nome"];
                    await context.Response.WriteAsync($"Ciao {nome} ");
                });
            });
        }
    }
}