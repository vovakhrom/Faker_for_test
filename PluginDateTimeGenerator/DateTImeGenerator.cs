using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakerLib.Interfaces;

namespace PluginDateTimeGenerator
{
    class DateTImeGenerator : IGenerator
    {
        public Type GeneratorType => typeof(DateTime);

        public object Create()
        {
            Random random = new Random();
            DateTime start = new DateTime(1909, 1, 1);
            return start.AddDays(random.Next((DateTime.Today - start).Days));
        }
    }
}