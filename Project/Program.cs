using System;
using System.Xml;
using System;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FakerLib.Faker faker = new FakerLib.Faker();
            User user = faker.Create<User>();
            Console.WriteLine(JsonConvert.SerializeObject(user, (Formatting) Formatting.Indented));

        }
    }
}