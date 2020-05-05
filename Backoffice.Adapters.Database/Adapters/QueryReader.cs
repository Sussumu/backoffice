using Backoffice.Adapters.Database.Configurations;
using Backoffice.Application.Models;
using Backoffice.Application.Ports;
using Dapper;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Backoffice.Adapters.QueryDatabase.Adapters
{
    public class QueryReader : IQueryGetter
    {
        public QueriesDatabaseConfiguration Configuration { get; }

        public QueryReader(QueriesDatabaseConfiguration configuration)
        {
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<QueryEntity> Get(int id)
        {
            using (var connection = new SqlConnection(Configuration.ConnectionString))
                return await connection.QueryFirstOrDefaultAsync<QueryEntity>(Query, new { id });
        }

        private static string Query
        {
            get => @"
                SELECT TOP 1 * FROM Query
                WHERE Id = @Id";
        }
    }
}
