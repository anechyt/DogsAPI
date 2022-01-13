using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsAPI.Backend.Application.CQRS.Commands.CreateDog
{
    public partial class CreateDogCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public float TailLength { get; set; }
        public float Weight { get; set; }
    }
}