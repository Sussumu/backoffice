using System.Collections.Generic;
using System.Linq;

namespace Backoffice.Application.Contracts
{
    public class Result
    {
        public bool Success { get; }
        public object Data { get; }
        public List<string> Errors { get; }

        public static Result Ok()
        {
            return new Result(true);
        }

        public static Result Ok(object data)
        {
            return new Result(true, data);
        }

        public static Result Error(object data)
        {
            return new Result(false, data);
        }

        public static Result Error(object data, IEnumerable<string> errors)
        {
            return new Result(false, data, errors);
        }

        private Result(bool success, object data = default, IEnumerable<string> errors = null)
        {
            Success = success;
            Data = data;
            Errors = errors.ToList();
        }
    }
}
