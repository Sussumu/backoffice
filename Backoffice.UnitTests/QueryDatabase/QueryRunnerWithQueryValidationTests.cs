using Backoffice.Adapters.QueryDatabase.Adapters;
using Backoffice.Application.Commands;
using Backoffice.Application.Contracts;
using Backoffice.Application.Errors;
using Backoffice.Application.Models;
using Backoffice.UnitTests.Attributes;
using FluentAssertions;
using NSubstitute;
using System.Threading.Tasks;
using Xunit;

namespace Backoffice.UnitTests.QueryDatabase
{
    public class QueryRunnerWithQueryValidationTests
    {
        [Theory, AutoNSubstituteData]
        public async Task Run_WhenNoQueryWithThatIdExists_ShouldReturnError(
            QueryRunnerWithQueryValidation sut,
            QueryRunnerCommand command)
        {
            sut.QueryReader.Get(command.Id)
                .Returns(null as QueryEntity);

            var result = await sut.Run(command);

            result.Errors.Should()
                .Contain(x => x.Message == QueryErrors.QueryByIdDoesNotExit.Message);
            result.Data.Should().BeNull();
        }

        [Theory, AutoNSubstituteData]
        public async Task Run_WhenQueryExists_ShouldExecuteQueryAndReturnResult(
            QueryRunnerWithQueryValidation sut,
            QueryRunnerCommand command,
            QueryEntity query,
            QueryRunResult runResult)
        {
            sut.QueryReader.Get(command.Id)
                .Returns(query);

            sut.Runner.Run(command).Returns(runResult);

            var result = await sut.Run(command);

            result.Errors.Should().BeEmpty();
            result.Data.Should().Be(runResult);
            result.Data.QueryId.Should().Be(command.Id);
        }
    }
}
