using Backoffice.Application.Commands;
using Backoffice.Application.Ports;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Backoffice.WebApi.Controllers
{
    [ApiController]
    [Route("query")]
    public class QueryWriterController : ControllerBase
    {
        public IQueryCreator QueryCreator { get; }
        public IQueryParamCreator QueryParamCreator { get; }

        public QueryWriterController(
            IQueryCreator queryCreator,
            IQueryParamCreator queryParamCreator)
        {
            QueryCreator = queryCreator ?? throw new System.ArgumentNullException(nameof(queryCreator));
            QueryParamCreator = queryParamCreator ?? throw new System.ArgumentNullException(nameof(queryParamCreator));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateQueryCommand command)
        {
            var queryId = await QueryCreator.Create(command);

            if (command.Params != null && command.Params.Any())
                await QueryParamCreator.Create(new CreateQueryParamCommand(queryId, command.Params));

            return Ok();
        }
    }
}
