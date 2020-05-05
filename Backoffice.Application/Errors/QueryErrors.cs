using Backoffice.Application.Contracts;

namespace Backoffice.Application.Errors
{
    public static class QueryErrors
    {
        public static Error QueryByIdDoesNotExit => new Error("The query required by this id does not exist.");
    }
}
