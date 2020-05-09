using Backoffice.Application.Commands;
using Backoffice.Application.Contracts;
using Backoffice.Application.Ports;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Backoffice.WebApi.Controllers
{
    [ApiController]
    [Route("query")]
    public class QueryRunnerController : ControllerBase
    {
        public IQueryRunnerHandler Handler { get; }

        public QueryRunnerController(IQueryRunnerHandler handler)
        {
            Handler = handler ?? throw new ArgumentNullException(nameof(handler));
        }

        [HttpPost]
        [Route("{id}/run")]
        public async Task<Result> Run(int id, [FromBody]object queryParams)
        {
            return await Handler.Run(new QueryRunnerCommand(id, queryParams));
        }
    }
}
