using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DogsAPI.Backend.Application
{
    public static class DependencyInjection
    {
        //public static IServiceCollection AddApplication(this IServiceCollection service)
        //{
        //    service.AddMediatR(Assembly.GetExecutingAssembly());
        //    return service;
        //}
        public static IServiceCollection AddApplication(
           this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services
                .AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
            services.AddTransient(typeof(ValidationBehavior<,>));
            return services;
        }
    }
}
