using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL1
{
    class Company
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }

        public Company()
        {
            Name = "None";
        }
        public Company(string name)
        {
            Name = name;
        }

        public void GetInfoCompany()
        {
            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine($"Название фирмы:{Name}:");
            Console.WriteLine("===============================");

            foreach (var item in Departments)
            {
                Console.WriteLine();
                Console.WriteLine($"{item.Name}:");
                Console.WriteLine();

                int count = 1;
                foreach (var item1 in item.Persons)
                {
                    Console.WriteLine($"N{count}  ФИО:   {item1.Name}   Возраст: {item1.Age}");
                    count++;
                }
            }
        }
    }
}
