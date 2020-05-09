using Backoffice.Application.Commands;
using System.Threading.Tasks;

namespace Backoffice.Application.Ports
{
    public interface IQueryCreator
    {
        Task<int> Create(CreateQueryCommand command);
    }
}
