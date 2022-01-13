using DogsAPI.Backend.Application.CQRS.Queries.GetListOfDogs;
using DogsAPI.Tests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace DogsAPI.Tests.Queries
{
    public class GetListOfDogsQueryHandlerTests : TestCommandBase
    {
        [Fact]
        public async void GetListOfDogsQueryHandler_Success()
        {
            var handler = new GetListOfDogsHandler(context);

            var result = await handler.Handle(
                new GetListOfDogsQuery
                {
                    
                }, CancellationToken.None);

            Assert.True(result.Length.Equals(2));
        }
    }
}
