using Backoffice.Application.Enums;
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
        public QueryTypes Type { get; set; }
    }
}
