using AutoMapper;
using DogsAPI.Backend.Core.Dtos;
using DogsAPI.Backend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsAPI.Backend.Application.Common.Mapping
{
    public class DogProfile : Profile
    {
        public DogProfile()
        {
            CreateMap<DogDto, Dog>()
                .ForMember(dog => dog.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dog => dog.Color, opt => opt.MapFrom(src => src.Color))
                .ForMember(dog => dog.TailLength, opt => opt.MapFrom(src => src.TailLength))
                .ForMember(dog => dog.Weight, opt => opt.MapFrom(src => src.Weight));   
        }
    }
}