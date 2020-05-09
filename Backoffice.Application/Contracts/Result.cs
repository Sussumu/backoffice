using System;
using System.Collections.Generic;
using System.Linq;

namespace Backoffice.Application.Contracts
{
    public class Result
    {
        public bool Success { get; }
        public object Data { get; }
        public Exception Exception { get; }
        public List<Error> Errors { get; }

        public static Result Ok() => new Result(true);

        public static Result Ok(object data) => new Result(true, data);

        public static Result Error(Exception ex) => new Result(false, ex);

        public static Result Error(Error error) => new Result(false, errors: new List<Error> { error });

        public static Result Error(IEnumerable<Error> errors) => new Result(false, errors: errors);

        private Result(bool success, object data = null, Exception exception = null, IEnumerable<Error> errors = null)
        {
            Success = success;
            Data = data;
            Exception = exception;
            Errors = errors?.ToList() ?? new List<Error>();
        }
    }
}
