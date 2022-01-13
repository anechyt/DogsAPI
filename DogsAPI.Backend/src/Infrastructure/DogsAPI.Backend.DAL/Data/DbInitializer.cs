using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsAPI.Backend.DAL.Data
{
    public class DbInitializer
    {
        public static void Initializer(DogsAPIDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
