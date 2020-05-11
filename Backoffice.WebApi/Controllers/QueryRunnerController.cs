using Backoffice.Application.Commands;
using Backoffice.Application.Contracts;
using Backoffice.Application.Ports;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
        public async Task<Result> Run(int id, [FromBody] JObject bodyQueryParams)
        {
            var queryParams = JsonConvert.DeserializeObject<Dictionary<string, object>>(bodyQueryParams.ToString(), new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return await Handler.Run(new QueryRunnerCommand(id, queryParams));
        }
    }
}
