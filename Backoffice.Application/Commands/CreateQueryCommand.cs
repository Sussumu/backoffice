using Backoffice.Application.Enums;
using Backoffice.Application.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backoffice.Application.Commands
{
    public class CreateQueryCommand
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Query { get; set; }

        [Required]
        public QueryTypes QueryType { get; set; }

        public List<QueryParam> Params { get; set; }
    }
}
