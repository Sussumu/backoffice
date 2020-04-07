using System.Collections.Generic;
using System.Linq;

namespace Backoffice.Application.Contracts
{
    public class Result<T>
    {
        public bool Success { get; }
        public T Data { get; }
        public List<string> Errors { get; }

        public static Result<T> Ok()
        {
            return new Result<T>(true);
        }

        public static Result<T> Ok(T data)
        {
            return new Result<T>(true, data);
        }

        public static Result<T> Error(T data)
        {
            return new Result<T>(false, data);
        }

        public static Result<T> Error(T data, IEnumerable<string> errors)
        {
            return new Result<T>(false, data, errors);
        }

        private Result(bool success, T data = default, IEnumerable<string> errors = null)
        {
            Success = success;
            Data = data;
            Errors = errors.ToList();
        }
    }
}
