using Backoffice.Adapters.Database.Configurations;
using Backoffice.Application.Commands;
using Backoffice.Application.Contracts;
using Backoffice.Application.Ports;
using Dapper;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Backoffice.Adapters.QueryDatabase.Adapters
{
    public class QueryRunner : IQueryRunner
    {
        public QueriesDatabaseConfiguration Configuration { get; }

        public QueryRunner(QueriesDatabaseConfiguration configuration)
        {
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<Result> Run(QueryRunnerCommand command)
        {
            using (var connection = new SqlConnection(Configuration.ConnectionString))
            {
                var result = await connection.QueryAsync(command.Query, command.Params);

                return Result.Ok(result);
            }
        }
    }
}
