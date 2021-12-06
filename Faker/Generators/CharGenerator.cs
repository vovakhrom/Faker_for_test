using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakerLib.Interfaces;

namespace FakerLib.Generators
{
    public class CharGenerator : IGenerator
    {
        static string Symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        public Type GeneratorType => typeof(Char);

        public object Create()
        {
            return Symbols[new Random().Next(Symbols.Length)];
        }
    }
}