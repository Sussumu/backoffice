using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SimpleInjector;

namespace Backoffice.WebApi
{
    public partial class Startup
    {
        private IConfiguration Configuration { get; }

        private readonly Container _container;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _container = new Container();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            services
                .AddControllers()
                .AddNewtonsoftJson();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Backoffice API", Version = "v1" });
            });

            ConfigureDependencyInjection(services, _container);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSimpleInjector(_container);

            _container.Verify();

            if (env.IsDevelopment())            
                app.UseDeveloperExceptionPage();            

            app.UseHttpsRedirection();            

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(options => {
                options
                    .WithOrigins("http://localhost:8081")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Backoffice API");
            });
        }
    }
}
