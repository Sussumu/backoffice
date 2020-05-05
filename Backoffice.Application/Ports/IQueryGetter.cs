using Backoffice.Application.Models;
using System.Threading.Tasks;

namespace Backoffice.Application.Ports
{
    public interface IQueryGetter
    {
        Task<QueryEntity> Get(int id);
    }
}
