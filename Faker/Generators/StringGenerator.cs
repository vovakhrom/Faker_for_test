using FakerLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLib.Generators
{
    public class StringGenerator : IGenerator
    {
        public Type GeneratorType => typeof(string);

        public object Create()
        {
            Random random = new Random();
            int length = random.Next(10);
            StringBuilder builder = new StringBuilder();
            CharGenerator chr = new CharGenerator();
            for (int i = 0; i < length; i++)
            {
                builder.Append(chr.Create());
            }
            return builder.ToString();
        }
    }
}