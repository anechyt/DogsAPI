using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsAPI.Backend.Application.CQRS.Commands.CreateDog
{
    public class CreateDogCommandValidator : AbstractValidator<CreateDogCommand>
    {
        public CreateDogCommandValidator()
        {
            RuleFor(dog => dog.Name).NotNull().MaximumLength(25);
            RuleFor(dog => dog.Color).NotNull().MaximumLength(25);
            RuleFor(dog => dog.TailLength).NotEmpty().GreaterThan(0);
            RuleFor(dog => dog.Weight).NotEmpty().GreaterThan(0);
        }
    }
}