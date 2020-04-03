using Backoffice.Application.Commands;
using Backoffice.Application.Ports;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Backoffice.WebApi.Controllers
{
    [ApiController]
    [Route("query")]
    public class QueryWriterController : ControllerBase
    {
        public ICreateQuery QueryCreator { get; }

        public QueryWriterController(ICreateQuery queryCreator)
        {
            QueryCreator = queryCreator ?? throw new System.ArgumentNullException(nameof(queryCreator));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateQueryCommand command)
        {
            await QueryCreator.Create(command);

            return Ok();
        }
    }
}
