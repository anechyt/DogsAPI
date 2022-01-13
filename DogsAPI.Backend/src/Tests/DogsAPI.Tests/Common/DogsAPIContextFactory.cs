using DogsAPI.Backend.Core.Entities;
using DogsAPI.Backend.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsAPI.Tests.Common
{
    public class DogsAPIContextFactory
    {
        public static Guid DogsId = Guid.NewGuid();

        public static DogsAPIDbContext Create()
        {
            var options = new DbContextOptionsBuilder<DogsAPIDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new DogsAPIDbContext(options);
            context.Database.EnsureCreated();
            context.Dogs.AddRange(
                new Dog
                {
                    Id = Guid.Parse("718ECCBC-7FBF-4D8D-803A-D19B5DAA0A86"),
                    Color = "Color1",
                    TailLength = 10,
                    Weight = 10
                });
            context.SaveChanges();
            return context;
        }

        public static void Destroy(DogsAPIDbContext context)
        {
            context.Database.EnsureCreated();
            context.Dispose();
        }
    }
}
