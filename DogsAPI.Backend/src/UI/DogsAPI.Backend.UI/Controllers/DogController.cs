using DogsAPI.Backend.Application.CQRS.Queries.GetListOfDogs;
using DogsAPI.Backend.Core.Entities;
using DogsAPI.Backend.UI.Controllers.Helpers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogsAPI.Backend.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("ping")]
        [ThrottleFilterAttribute(Name = "Throttle", Message = "You must wait {n} seconds before accessing this url again.", Seconds = 1)]
        public ActionResult<string> Ping()
        {
            return "Dogs house service. Version 1.0.1";
        }

        [HttpGet("dogs")]
        [ThrottleFilterAttribute(Name = "Throttle", Message = "You must wait {n} seconds before accessing this url again.", Seconds = 1)]
        public async Task<Dog[]> Get()
        {
            return await _mediator.Send(new GetListOfDogsQuery());
        }

        [HttpPost("dog")]
        [ThrottleFilterAttribute(Name = "Throttle", Message = "You must wait {n} seconds before accessing this url again.", Seconds = 1)]
        public async Task<Guid> CreateDog(Application.CQRS.Commands.CreateDog.CreateDogCommand dog)
        {
            return await _mediator.Send(dog);
        }
    }
}