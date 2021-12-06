using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakerLib.Interfaces;
namespace FakerLib.Generators
{

    public class BoolGenerator : IGenerator
    {
        public Type GeneratorType => typeof(bool);

        public object Create()
        {
            return new Random().Next(0, 2) == 1;
        }
    }
}