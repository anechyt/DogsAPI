using AutoMapper;
using AutoMapper.QueryableExtensions;
using DogsAPI.Backend.Application.Common.Intefaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DogsAPI.Backend.Application.CQRS.Queries.GetListOfDogs
{
    public class GetListOfDogsHandler
        : IRequestHandler<GetListOfDogsQuery, GetListOfDogsVm>
    {
        private readonly IDogsAPIDbContext _context;
        private readonly IMapper _mapper;

        public GetListOfDogsHandler(IDogsAPIDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetListOfDogsVm> Handle(GetListOfDogsQuery request, CancellationToken cancellationToken)
        {
            var dogs = await _context.Dogs
                .Where(dog => dog.Id == request.Id)
                .ProjectTo<GetListOfDogsDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new GetListOfDogsVm { Dogs = dogs };
        }
    }
}