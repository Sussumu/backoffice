using System.Collections.Generic;

namespace Backoffice.Application.Commands
{
    public class QueryRunnerCommand
    {
        public int Id { get; }

        public string Query { get; set; }

        public Dictionary<string, object> Params { get; set; }

        public QueryRunnerCommand(int id, Dictionary<string, object> queryParams)
        {
            Id = id;
            Params = queryParams;
        }
    }
}
