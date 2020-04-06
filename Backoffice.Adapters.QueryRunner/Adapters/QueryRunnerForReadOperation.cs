using Backoffice.Application.Contracts;
using Backoffice.Application.Ports;
using System.Threading.Tasks;

namespace Backoffice.Adapters.QueryRunner.Adapters
{
    public class QueryRunnerForReadOperation : IQueryRunner
    {
        public async Task<Result> Run(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}
