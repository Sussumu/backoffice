using Backoffice.Application.Commands;
using Backoffice.Application.Contracts;
using Backoffice.Application.Ports;
using System;
using System.Threading.Tasks;

namespace Backoffice.Adapters.QueryDatabase.Adapters
{
    public class QueryRunnerWithErrorHandler : IQueryRunner
    {
        public IQueryRunner Next { get; }

        public QueryRunnerWithErrorHandler(IQueryRunner next)
        {
            Next = next ?? throw new ArgumentNullException(nameof(next));
        }

        public async Task<QueryRunResult> Run(QueryRunnerCommand command)
        {
            try
            {
                return await Next.Run(command);
            }
            catch (Exception ex)
            {
                // TODO: log and return something better
                return null;
            }
        }
    }
}
