using Backoffice.Application.Models;
using System.Collections.Generic;

namespace Backoffice.Application.Commands
{
    public class CreateQueryParamCommand
    {
        public List<QueryParam> Params { get; }

        public CreateQueryParamCommand(int queryId, List<QueryParam> @params)
        {
            foreach (var param in @params)
                param.SetQueryId(queryId);

            Params = @params;
        }
    }
}
