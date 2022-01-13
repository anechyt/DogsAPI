using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsAPI.Backend.Application.CQRS.Queries.GetListOfDogs
{
    public class GetListOfDogsQuery : IRequest<GetListOfDogsVm>
    {
        public Guid Id { get; set; }
    }
}