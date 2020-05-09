namespace Backoffice.Application.Commands
{
    public class QueryRunnerCommand
    {
        public int Id { get; }

        public string Query { get; set; }

        public object Params { get; set; }

        public QueryRunnerCommand(int id, object queryParams)
        {
            Id = id;
            Params = queryParams;
        }
    }
}
