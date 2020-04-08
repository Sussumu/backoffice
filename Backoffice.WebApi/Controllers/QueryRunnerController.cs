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
        public IQueryRunner Runner { get; }

        public QueryRunnerController(IQueryRunner runner)
        {
            Runner = runner ?? throw new ArgumentNullException(nameof(runner));
        }

        [Route("{id}/run")]
        public async Task<Result> Run(int id)
        {
            return await Runner.Run(id);
        }
    }
}
