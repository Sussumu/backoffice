using Backoffice.Application.Commands;
using Backoffice.Application.Contracts;
using System.Threading.Tasks;

namespace Backoffice.Application.Ports
{
    public interface IQueryRunner
    {
        Task<Result> Run(QueryRunnerCommand command);
    }
}
