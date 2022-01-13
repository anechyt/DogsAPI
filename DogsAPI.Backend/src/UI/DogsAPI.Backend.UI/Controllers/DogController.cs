using DogsAPI.Backend.Application.CQRS.Queries.GetListOfDogs;
using DogsAPI.Backend.Core.Entities;
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
        public ActionResult<string> Ping()
        {
            return "Dogs house service. Version 1.0.1";
        }

        [HttpGet("dogs")]
        public async Task<Dog[]> Get()
        {
            return await _mediator.Send(new GetListOfDogsQuery());
        }

        [HttpPost]
        public async Task<Guid> CreateDog(Application.CQRS.Commands.CreateDog.CreateDogCommand dog)
        {
            return await _mediator.Send(dog);
        }
    }
}