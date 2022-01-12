using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsAPI.Backend.Core.Entities
{
    public class Dog : BaseEntity
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public float TailLength { get; set; }
        public float Weight { get; set; }

        public Dog(string name, string color, float tailLength, float weight)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Color = color ?? throw new ArgumentNullException(nameof(color));
            TailLength = tailLength;
            Weight = weight;

            if(tailLength < 0)
            {
                throw new Exception("Value must be positive!");
            }
            if (weight < 0)
            {
                throw new Exception("Value must be positive!");
            }
        }
    }
}