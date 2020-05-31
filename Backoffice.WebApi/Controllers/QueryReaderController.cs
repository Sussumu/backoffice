using Backoffice.Application.Contracts;
using Backoffice.Application.Ports;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Backoffice.WebApi.Controllers
{
    [Route("query")]
    [ApiController]
    public class QueryReaderController : ControllerBase
    {
        public IQueryGetter QueryReader { get; }

        public QueryReaderController(IQueryGetter queryReader)
        {
            QueryReader = queryReader ?? throw new System.ArgumentNullException(nameof(queryReader));
        }

        [HttpGet]
        public async Task<Result> Get()
        {
            return Result.Ok(await QueryReader.Get());
        }
    }
}