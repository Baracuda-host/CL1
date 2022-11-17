using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL1
{
    public class Person
    {
        public string namePerson;
        public int age;

        public Person()
        {
            namePerson = "X";
            age = 0;
        }

        public Person(string name, int age)
        {
            namePerson = name;
            this.age = age;
        }
              
    }

}
