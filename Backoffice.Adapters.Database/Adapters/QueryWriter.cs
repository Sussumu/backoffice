using Backoffice.Application.Commands;
using Backoffice.Application.Ports;
using System;
using System.Threading.Tasks;

namespace Backoffice.Adapters.Database.Adapters
{
    public class QueryWriter : ICreateQuery
    {
        public Task Create(CreateQueryCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
