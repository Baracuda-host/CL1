﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL1
{
    public class Department
    {
        public string department;
        public List<Person> Persons { get; set; }

        public Department()
        {
            department = "";
        }
        public Department(string nameDepart)
        {
            department= nameDepart;
        }
    }

}
