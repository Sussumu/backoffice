using Backoffice.Adapters.Database.Adapters;
using Backoffice.Adapters.Database.Configurations;
using Backoffice.Adapters.QueryDatabase.Adapters;
using Backoffice.Application.Ports;
using Microsoft.Extensions.Configuration;
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

            ConfigureBinds(container);
            ConfigureAdapters(container);
        }

        private void ConfigureBinds(Container container)
        {
            var queriesDatabaseConfiguration = new QueriesDatabaseConfiguration();
            container.RegisterInstance(queriesDatabaseConfiguration);
            Configuration.Bind("QueriesDatabase", queriesDatabaseConfiguration);
        }

        private static void ConfigureAdapters(Container container)
        {
            container.Register<ICreateQuery, QueryWriter>();

            container.Register<IQueryGetter, QueryReader>();

            container.Register<IQueryRunnerHandler, QueryRunnerWithQueryValidation>();

            container.Register<IQueryRunner, QueryRunner>();
            container.RegisterDecorator<IQueryRunner, QueryRunnerWithErrorHandler>();
        }
    }
}
