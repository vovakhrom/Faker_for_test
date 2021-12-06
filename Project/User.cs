using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class User
    {
        public string name;
        //properties
        public int age { get; set; }
        public double money;
        public DateTime date;
        public List<Dog> dogs;
        public Profile profile;
        
    }


    class Dog
    {
        public String name;
        public User owner;
        public long longValue;
    }

    class Profile
    {
        public String address;

    }
}