using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStructure
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //»Õÿ Â‰« ﬂ· «·”Ì—›Ì”Ì” «··Ì »⁄„·Â« 
            services.AddControllersWithViews();//MVC
            //services.AddRazorPages();//Razor page 
            //services.AddControllers();//web api
            //services.AddMvc();//Mix 3 Projects
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //»Ì»ﬁÌ ›ÌÂ« «·„Ìœ· ÊÌ— » «⁄  «·ﬂÌ” Ì—«· 
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();//Get static files(css,js,Image) 
            app.UseRouting();// Ê» ‘Ê› ·Ê ›Ì —Ê  “ÌÊ ⁄‰œ‰«UseEndPoint» —ÊÕ  ﬂ·„ «·„Ìœ· ÊÌ— «··Ì «”„Â« https:/localhost:44324/ÂÊ œ« «·—«ÊÌ 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapGet("Index", async context =>
                {
                    await context.Response.WriteAsync("Hello Joo!");
                });
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{Controller=Movies}/{action=Index}/{id:int?}"// constraintÊ default  œÌ ﬂœ« ÿ—Ìﬁ… «”Â· ⁄‘«‰ ‰⁄„· 
                    //defaults: new { Action = "Index" },
                    //constraints: new { id = new IntRouteConstraint() }
                    );
                endpoints.MapControllerRoute
                (
                    name: "Dafault",
                    pattern: "{Controller=Home}/{action=Index}"
                    );
            });
        }
    }
}
