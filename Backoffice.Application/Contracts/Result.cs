using System.Collections.Generic;
using System.Linq;

namespace Backoffice.Application.Contracts
{
    public class Result
    {
        public bool Success { get; }
        public List<Error> Errors { get; }

        public static Result Ok() => new Result(true);

        public static Result Error(Error error) => new Result(false, errors: new List<Error> { error });

        public static Result Error(IEnumerable<Error> errors) => new Result(false, errors);

        private Result(bool success, IEnumerable<Error> errors = null)
        {
            Success = success;
            Errors = errors?.ToList() ?? new List<Error>();
        }
    }

    public class Result<T> where T : class
    {
        public bool Success { get; }
        public T Data { get; }
        public List<Error> Errors { get; }

        public static Result<T> Ok(T data) => new Result<T>(true, data);

        public static Result<T> Error(T data) => new Result<T>(false, data);

        public static Result<T> Error(Error error) => new Result<T>(false, null, new List<Error> { error });

        public static Result<T> Error(T data, Error error) => new Result<T>(false, data, new List<Error> { error });

        public static Result<T> Error(T data, IEnumerable<Error> errors) => new Result<T>(false, data, errors);

        private Result(bool success, T data, IEnumerable<Error> errors = null)
        {
            Success = success;
            Data = data;
            Errors = errors?.ToList() ?? new List<Error>();
        }
    }
}
