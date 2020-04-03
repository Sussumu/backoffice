using Backoffice.Application.Commands;
using System.Threading.Tasks;

namespace Backoffice.Application.Ports
{
    public interface ICreateQuery
    {
        Task Create(CreateQueryCommand command);
    }
}
