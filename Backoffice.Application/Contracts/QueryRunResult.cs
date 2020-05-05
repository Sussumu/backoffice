using System.Collections.Generic;

namespace Backoffice.Application.Contracts
{
    public class QueryRunResult
    {
        public int QueryId { get; set; }

        public IEnumerable<dynamic> Result { get; }

        public QueryRunResult(IEnumerable<dynamic> result)
        {
            Result = result;
        }
    }
}
