using Backoffice.Application.Commands;
using System.Threading.Tasks;

namespace Backoffice.Application.Ports
{
    public interface IQueryParamCreator
    {
        Task Create(CreateQueryParamCommand queryParamsCommand);
    }
}
