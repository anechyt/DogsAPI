using DogsAPI.Backend.Application.Common.Intefaces;
using DogsAPI.Backend.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DogsAPI.Backend.Application.CQRS.Commands.CreateDog
{
    public class CreateDogCommandHandler
        : IRequestHandler<CreateDogCommand, Guid>
    {
        private readonly IDogsAPIDbContext _context;
        public CreateDogCommandHandler(IDogsAPIDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> Handle(CreateDogCommand request, CancellationToken cancellationToken)
        {
            var dog = new Dog
            {
                Name = request.Name,
                Color = request.Color,
                TailLength = request.TailLength,
                Weight = request.Weight
            };

            await _context.Dogs.AddAsync(dog, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return dog.Id;
        }
    }
}