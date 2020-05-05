using Backoffice.Application.Enums;

namespace Backoffice.Application.Models
{
    public class QueryEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Query { get; set; }

        public QueryTypes Type { get; set; }
    }
}
