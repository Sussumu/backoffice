using Backoffice.Application.Contracts;
using Backoffice.Application.Ports;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backoffice.Adapters.QueryRunner.Adapters
{
    public class QueryRunnerForReadOperation : IQueryRunner<List<object>>
    {
        public async Task<Result<List<object>>> Run(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}
