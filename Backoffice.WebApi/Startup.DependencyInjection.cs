using Backoffice.Adapters.Database.Adapters;
using Backoffice.Application.Ports;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;

namespace Backoffice.WebApi
{
    public partial class Startup
    {
        private void ConfigureDependencyInjection(
            IServiceCollection services,
            Container container)
        {
            services.AddSimpleInjector(container, options =>
            {
                options
                    .AddAspNetCore()
                    .AddControllerActivation();
            });

            container.Register<ICreateQuery, QueryWriter>();

            _container.Verify();
        }
    }
}
