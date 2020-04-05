using Backoffice.Application.Enums;
using System;

namespace Backoffice.Application.Commands
{
    public class CreateQueryCommand
    {
        public string Query { get; }

        public QueryTypes Type { get; }

        private CreateQueryCommand() { }

        public CreateQueryCommand(
            string query,
            QueryTypes type)
        {
            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException(
                    "The query must not be empty.",
                    nameof(query));

            if (Enum.IsDefined(typeof(QueryTypes), type) is false)
                throw new ArgumentException(
                    "The query type must be one of the valid values.",
                    nameof(query));

            Query = query;
            Type = type;
        }
    }
}
