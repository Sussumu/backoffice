using Backoffice.Application.Commands;

namespace Backoffice.Application.Ports
{
    public interface ICreateQuery
    {
        void Create(CreateQueryCommand command);
    }
}
