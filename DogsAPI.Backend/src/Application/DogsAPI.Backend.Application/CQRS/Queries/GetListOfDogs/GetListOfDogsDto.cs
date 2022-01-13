using AutoMapper;
using DogsAPI.Backend.Application.Common.Mapping;
using DogsAPI.Backend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsAPI.Backend.Application.CQRS.Queries.GetListOfDogs
{
    public class GetListOfDogsDto : IMapWith<Dog>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public float TailLength { get; set; }
        public float Weight { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Dog, GetListOfDogsDto>()
                .ForMember(dogDto => dogDto.Id, opt => opt.MapFrom(dog => dog.Id))
                .ForMember(dogDto => dogDto.Name, opt => opt.MapFrom(dog => dog.Name))
                .ForMember(dogDto => dogDto.TailLength, opt => opt.MapFrom(dog => dog.TailLength))
                .ForMember(dogDto => dogDto.Weight, opt => opt.MapFrom(dog => dog.Weight));
        }
    }
}