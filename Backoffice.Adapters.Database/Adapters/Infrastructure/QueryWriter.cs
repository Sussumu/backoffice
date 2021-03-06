﻿using Backoffice.Adapters.Database.Configurations;
using Backoffice.Application.Commands;
using Backoffice.Application.Ports;
using Dapper;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Backoffice.Adapters.Database.Adapters.Infrastructure
{
    public class QueryWriter : IQueryCreator
    {
        public QueriesDatabaseConfiguration Configuration { get; }

        public QueryWriter(QueriesDatabaseConfiguration configuration)
        {
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<int> Create(CreateQueryCommand command)
        {
            using (var connection = new SqlConnection(Configuration.ConnectionString))
                return await connection.ExecuteScalarAsync<int>(Query, command);
        }

        private static string Query
        {
            get => @"
                INSERT INTO Query (Name, Description, Query, QueryType) VALUES
                (@Name, @Description, @Query, @QueryType);

                SELECT SCOPE_IDENTITY()";
        }
    }
}
