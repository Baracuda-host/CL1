using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL1
{
    
    internal class Program
    {       
        static void Main(string[] args)
        {
            Company company1 = new Company("Aviazavod");                //создали обект класса компани компания1

            #region создание отделов

            List<Department> departments = new List<Department>()               //создали список из 3х отделов 
            {
                new Department("Director"),
                new Department("Marketing"),
                new Department("Otdel Personal"),

            };
                     
            company1.Departments = departments;                       //присваиваем компании1 3 отдела

            #endregion

            #region создание сотрудников
            List<Person> persons1 = new List<Person>()
            {
               new Person("Серегин И.А.", 38),
               new Person("Ванилин К.А.", 37),
            };
             
            company1.Departments[0].Persons = persons1;

            List<Person> persons2 = new List<Person>()
            {
                new Person("Иванов В.А.", 30),
                new Person("Саратин И.Н.", 35),
                new Person("Волгин В.А.", 34),
            };
                        
            company1.Departments[1].Persons = persons2;

            List<Person> persons3 = new List<Person>()
            {
                new Person("Савор М.С.", 25),
                new Person("Фывавич В.С.", 50),
                new Person("Игнатов С.В.", 30),
                new Person("Еваныч В.А.", 36),

            };
            
            company1.Departments[2].Persons = persons3;

            company1.GetInfoCompany();

            //вторая компания========================================

            Company company2 = new Company("StalMost");

            List<Department> departments2 = new List<Department>()
            {
                new Department("Director"),
                new Department("Buhgalter"),
                new Department("Otdel Security"),
            };

            company2.Departments = departments2;

            List<Person> persons11 = new List<Person>()
            {
               new Person("Буууга И.А.", 38),
               new Person("Екат К.А.", 37),
            };

            company2.Departments[0].Persons = persons1;

            List<Person> persons22 = new List<Person>()
            {
                new Person("Иварон В.А.", 30),
                new Person("Каратин И.Н.", 35),
                new Person("Солгин В.А.", 34),

            };

            company2.Departments[1].Persons = persons22;

            List<Person> persons33 = new List<Person>()
            {
                new Person("Чавор М.С.", 25),
                new Person("Пывавич В.С.", 50),
                new Person("Егнатов С.В.", 30),
                new Person("Ованыч В.А.", 36),

            };
            company2.Departments[2].Persons = persons33;

            company2.GetInfoCompany();
            
            #endregion

            Console.ReadLine();

        }
    }
}
