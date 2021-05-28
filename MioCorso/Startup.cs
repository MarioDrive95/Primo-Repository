using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MyCourse
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
// Aggiungo i services di asp mvc che il MIDDLEWARE di routing userà per trovare e costruire  il CONTROLLER
// e per utlizizzare l'ACTION richiesta

// Compatibility Version serve ad apportare migliorie in caso di versioni piu moderne

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

// Inserisco questa istruzioine per disabilitare l EndPointRouting per poter utilizzare (UseMvc)
            services.AddMvc(options => options.EnableEndpointRouting = false);
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            //if (env.IsDevelopment())
            if (env.IsEnvironment("Development"))
            {
                           // Middleware per gestire l eccezioni

                app.UseDeveloperExceptionPage();  
            }
            app.UseStaticFiles();
            
            //app.UseMvcWithDefaultRoute();
                       
                         // Middleware di rout (aggiunto manualmente) che gestira la richiesta di default
            app.UseMvc(routeBuilder => 
            {
                // /courses/detail/5
                // in mancanza di indirizzazioni il route esegue per default il CONTROLLER Home e ACTION index
                routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}


