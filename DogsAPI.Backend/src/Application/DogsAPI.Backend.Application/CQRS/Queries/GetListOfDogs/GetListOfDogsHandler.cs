using DogsAPI.Backend.Application.Common.Intefaces;
using DogsAPI.Backend.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DogsAPI.Backend.Application.CQRS.Queries.GetListOfDogs
{
    public class GetListOfDogsHandler
        : IRequestHandler<GetListOfDogsQuery, Dog[]>
    {
        private readonly IDogsAPIDbContext _context;

        public GetListOfDogsHandler(IDogsAPIDbContext context)
        {
            _context = context;
        }

        public Task<Dog[]> Handle(GetListOfDogsQuery request, CancellationToken cancellationToken)
        {
            var result = _context.Dogs.ToArray();
            return Task.FromResult(result);
        }
    }
}
