using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakerLib.Interfaces;

namespace FakerLib.Generators
{
    public class DoubleGenerator : IGenerator
    {
        public Type GeneratorType => typeof(Double);

        public object Create()
        {
            return new Random().NextDouble();
        }
    }
}