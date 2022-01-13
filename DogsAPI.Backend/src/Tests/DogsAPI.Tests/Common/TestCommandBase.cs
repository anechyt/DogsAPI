using DogsAPI.Backend.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsAPI.Tests.Common
{
    public abstract class TestCommandBase : IDisposable
    {
        protected readonly DogsAPIDbContext context;

        public TestCommandBase()
        {
            context = DogsAPIContextFactory.Create();
        }

        public void Dispose()
        {
            DogsAPIContextFactory.Destroy(context);
        }
    }
}
