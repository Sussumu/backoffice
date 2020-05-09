namespace Backoffice.Application.Models
{
    public class QueryParam
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int QueryId { get; private set; }

        public void SetQueryId(int queryId) => QueryId = queryId;
    }
}

