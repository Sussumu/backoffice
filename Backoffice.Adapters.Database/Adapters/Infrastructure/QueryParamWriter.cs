using Backoffice.Adapters.Database.Configurations;
using Backoffice.Application.Commands;
using Backoffice.Application.Ports;
using Dapper;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Transactions;

namespace Backoffice.Adapters.Database.Adapters.Infrastructure
{
    public class QueryParamWriter : IQueryParamCreator
    {
        public QueriesDatabaseConfiguration Configuration { get; }

        public QueryParamWriter(QueriesDatabaseConfiguration configuration)
        {
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task Create(CreateQueryParamCommand queryParamsCommand)
        {
            using (var connection = new SqlConnection(Configuration.ConnectionString))
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                await connection.ExecuteAsync(Query, queryParamsCommand.Params);

                scope.Complete();
            }
        }

        private static string Query
        {
            get => @"
                INSERT INTO QueryParam (Name, Description, QueryId) VALUES
                (@Name, @Description, @QueryId)";
        }
    }
}
