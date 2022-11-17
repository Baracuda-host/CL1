using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { set; get; }

        public Person()
        {
            Name = "X";
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
