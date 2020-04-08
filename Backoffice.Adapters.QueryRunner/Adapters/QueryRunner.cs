using Backoffice.Application.Contracts;
using Backoffice.Application.Ports;
using System;
using System.Threading.Tasks;

namespace Backoffice.Adapters.QueryRunner.Adapters
{
    public class QueryRunner : IQueryRunner
    {
        public Task<Result> Run(int id)
        {
            throw new NotImplementedException();
        }
    }
}
