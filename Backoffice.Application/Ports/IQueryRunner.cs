using Backoffice.Application.Contracts;
using System.Threading.Tasks;

namespace Backoffice.Application.Ports
{
    public interface IQueryRunner<T>
    {
        Task<Result<T>> Run(long id);
    }
}
