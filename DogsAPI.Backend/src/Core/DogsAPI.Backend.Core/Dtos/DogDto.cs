using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsAPI.Backend.Core.Dtos
{
    public class DogDto
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public float TailLength { get; set; }
        public float Weight { get; set; }
    }
}
