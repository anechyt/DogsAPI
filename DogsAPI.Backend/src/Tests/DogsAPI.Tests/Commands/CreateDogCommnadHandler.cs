using DogsAPI.Backend.Application.CQRS.Commands.CreateDog;
using DogsAPI.Tests.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace DogsAPI.Tests.Commands
{
    public class CreateDogCommnadHandlerTests : TestCommandBase
    {
        [Fact]
        public async Task CreateDogCommandHandler_Success()
        {
            var handler = new CreateDogCommandHandler(context);
            var dogname = "not name";
            var dogcolor = "not color";
            var dogteil = 7;
            var dogweight = 7;

            var dogId = await handler.Handle(new CreateDogCommand
            {
                Name = dogname,
                Color = dogcolor,
                TailLength = dogteil,
                Weight = dogweight
            },
            CancellationToken.None);

            Assert.NotNull(
                await context.Dogs.SingleOrDefaultAsync(dog =>
                    dog.Id == dogId && dog.Name == dogname &&
                    dog.TailLength == dogteil && dog.Weight == dogweight));
        }
    }
}
