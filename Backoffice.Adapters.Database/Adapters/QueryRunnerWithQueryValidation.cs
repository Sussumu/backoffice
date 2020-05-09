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

        public async Task<Result> Run(QueryRunnerCommand command)
        {
            var query = await QueryReader.Get(command.Id);

            if (query is null)
                return Result.Error(QueryErrors.QueryByIdDoesNotExit);

            command.Query = query.Query;

            return await Runner.Run(command);
        }
    }
}