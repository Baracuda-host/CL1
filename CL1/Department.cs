using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL1
{
    public class Department
    {
        public string Name { get; set; }
        public List<Person> Persons { get; set; }
        public Department()
        {
            Name = "";
        }
        public Department(string nameDepart)
        {
            Name = nameDepart;
        }
    }
}
