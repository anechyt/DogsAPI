using DogsAPI.Backend.Application.CQRS.Queries.GetListOfDogs;
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

        [HttpGet]
        public ActionResult<string> Ping()
        {
            return "Hello";
        }
    }
}
