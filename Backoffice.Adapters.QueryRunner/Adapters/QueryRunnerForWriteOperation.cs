using Backoffice.Application.Contracts;
using Backoffice.Application.Ports;
using System.Threading.Tasks;

namespace Backoffice.Adapters.QueryRunner.Adapters
{
    public class QueryRunnerForWriteOperation : IQueryRunner<int>
    {
        public async Task<Result<int>> Run(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}
