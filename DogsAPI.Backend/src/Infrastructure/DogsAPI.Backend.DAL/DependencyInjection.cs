using AutoMapper.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogsAPI.Backend.DAL.Data;
using DogsAPI.Backend.Application.Common.Intefaces;

namespace DogsAPI.Backend.DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<DogsAPIDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<IDogsAPIDbContext>(provider =>
                provider.GetService<DogsAPIDbContext>());
            return services;
        }
    }
}
