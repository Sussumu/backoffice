using Backoffice.Application.Commands;
using Backoffice.Application.Contracts;
using System.Threading.Tasks;

namespace Backoffice.Application.Ports
{
    public interface IQueryRunnerHandler
    {
        Task<Result> Run(QueryRunnerCommand command);
    }
}
