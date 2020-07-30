using Gateways;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Presenters;
using Presenters.Hubs;
using UseCases;

namespace CleanSample.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // UseCase services
            services.RegisterUseCasesServices();

            // Gateway services shouldn't be used from UI project directly
            services.RegisterGatewaysServices();

            // Presenter services shouldn't be used from UI project directly
            services.RegisterPresentersServices();

            services.AddMvc(o => o.Conventions.Add(new FeatureConvention()))
           .AddRazorOptions(options =>
           {
               // {0} - Action Name
               // {1} - Controller Name
               // {2} - Area Name
               // {3} - Feature Name
               // Replace normal view location entirely
               options.ViewLocationFormats.Clear();
               options.ViewLocationFormats.Add("/{3}/{1}/{0}.cshtml");
               options.ViewLocationFormats.Add("/{3}/{0}.cshtml");
               options.ViewLocationFormats.Add("/Shared/{0}.cshtml");
               options.ViewLocationExpanders.Add(new FeatureViewLocationExpander());
           });

            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error/Index");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                 name: "featuresRoute",
                 pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<ToDoHub>("/todoHub");
            });
        }
    }
}
