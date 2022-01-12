using DogsAPI.Backend.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsAPI.Backend.DAL.EntityConfiguration
{
    internal class DogsConfiguration : IEntityTypeConfiguration<Dog>
    {
        public void Configure(EntityTypeBuilder<Dog> builder)
        {
            builder.HasKey(dog => dog.Id);
            builder.HasIndex(dog => dog.Id).IsUnique();
            builder.Property(dog => dog.Name).HasMaxLength(25).IsRequired();
            builder.Property(dog => dog.TailLength).IsRequired();
            builder.Property(dog => dog.Weight).IsRequired();
        }
    }
}
