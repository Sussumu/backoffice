using Backoffice.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backoffice.Application.Ports
{
    public interface IQueryGetter
    {
        Task<QueryEntity> Get(int id);
        Task<IEnumerable<QueryEntity>> Get();
    }
}
