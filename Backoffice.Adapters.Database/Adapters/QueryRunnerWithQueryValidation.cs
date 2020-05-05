using Backoffice.Application.Commands;
using Backoffice.Application.Contracts;
using Backoffice.Application.Errors;
using Backoffice.Application.Ports;
using System;
using System.Threading.Tasks;

namespace Backoffice.Adapters.QueryDatabase.Adapters
{
    public class QueryRunnerWithQueryValidation : IQueryRunnerHandler
    {
        public IQueryRunner Runner { get; }
        public IQueryGetter QueryReader { get; }

        public QueryRunnerWithQueryValidation(
            IQueryRunner runner,
            IQueryGetter queryReader)
        {
            Runner = runner ?? throw new ArgumentNullException(nameof(runner));
            QueryReader = queryReader ?? throw new ArgumentNullException(nameof(queryReader));
        }

        public async Task<Result<QueryRunResult>> Run(QueryRunnerCommand command)
        {
            var query = await QueryReader.Get(command.Id);

            if (query is null)
                return Result<QueryRunResult>.Error(QueryErrors.QueryByIdDoesNotExit);

            command.Query = query.Query;

            var result = await Runner.Run(command);

            result.QueryId = command.Id;

            return Result<QueryRunResult>.Ok(result);
        }
    }
}
