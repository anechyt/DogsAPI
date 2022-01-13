using DogsAPI.Backend.Application.Common.Intefaces;
using DogsAPI.Backend.Core.Entities;
using DogsAPI.Backend.DAL.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsAPI.Backend.DAL.Data
{
    public class DogsAPIDbContext : DbContext, IDogsAPIDbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public DogsAPIDbContext(DbContextOptions<DogsAPIDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new DogsConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
