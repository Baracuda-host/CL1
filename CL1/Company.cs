using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL1
{
    class Company
    {
        public string nameCompany;

        public List<Department> Departments { get; set; }

        public Company()
        {
            nameCompany = "None";
        }

        public Company(string name)
        {
            nameCompany = name;
        }

        public void GetInfoCompany()
        {
            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine($"Название фирмы:{nameCompany}:");
            Console.WriteLine("===============================");

            foreach (var item in Departments)
            {
                Console.WriteLine();
                Console.WriteLine($"{item.department}:");
                Console.WriteLine();

                int count = 1;
                foreach (var item1 in item.Persons)
                {
                    Console.WriteLine($"N{count}  ФИО:   {item1.namePerson}   Возраст: {item1.age}");
                    count++;
                }
            }
        }
    }
}
