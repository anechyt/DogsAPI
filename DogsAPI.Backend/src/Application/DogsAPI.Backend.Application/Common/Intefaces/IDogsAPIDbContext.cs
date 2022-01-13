using DogsAPI.Backend.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DogsAPI.Backend.Application.Common.Intefaces
{
    public interface IDogsAPIDbContext
    {
        DbSet<Dog> Dogs { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
