using Backoffice.Adapters.Database.Configurations;
using Backoffice.Application.Commands;
using Backoffice.Application.Ports;
using Dapper;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Backoffice.Adapters.Database.Adapters.Infrastructure
{
    public class QueryWriter : ICreateQuery
    {
        public QueriesDatabaseConfiguration Configuration { get; }

        public QueryWriter(QueriesDatabaseConfiguration configuration)
        {
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task Create(CreateQueryCommand command)
        {
            using (var connection = new SqlConnection(Configuration.ConnectionString))
                await connection.ExecuteScalarAsync(Query, command);
        }

        private static string Query
        {
            get => @"
                INSERT INTO Query (Name, Description, Query, Type) VALUES
                (@Name, @Description, @Query, @Type)";
        }
    }
}
