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


        public Department[] Departments;


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
            Console.WriteLine("===============================");
            Console.WriteLine($"Название фирмы:{nameCompany}:");
            Console.WriteLine("===============================");
            
            

            foreach (var item in Departments)
            {
                Console.WriteLine();
                Console.WriteLine($"{ item.department}:");
                Console.WriteLine();

                int count = 1;
                foreach (var item1 in item.Persons)
                {
                    Console.WriteLine($"N{count}  ФИО:   { item1.namePerson}   Возраст: {item1.age}");
                    
                    count++;
                }
                
            }
            


        }

    }

   


    internal class Program
    {
        

        static void Main(string[] args)
        {
            Company company1 = new Company("Aviazavod");                //создали обект класса компани компания1

            #region создание отделов
            

            Department[] departments = new Department[3];               //создали массив обьекта 3 отдела 
            
            //departments[0] = new Department                                 //создаем первый отдел и присвам имя 
            //{
            //    department = "Director",
            //    Persons = new Person[] { new Person { namePerson = "PP" } }
            //};


            departments[0] = new Department();
            departments[1] = new Department();
            departments[2] = new Department();
            

            departments[0].department = "Director";                     //называем отделы 3 шт
            departments[1].department = "Marketing";
            departments[2].department = "Otdel Personal";

           
            company1.Departments = departments;                       //присваиваем компании1 3 отдела

            #endregion

            #region создание сотрудников
            Person[] persons1 = new Person[2];                        //как присвоить отделам нужное количество
                                                                      //сотрудников и задать им параметры
            persons1[0] = new Person("Серегин И.А.", 38);
            persons1[1] = new Person("Ванилин К.А.", 37);


            company1.Departments[0].Persons = persons1;

            //company1.Departments[0].Persons[0].namePerson = "X";

            

            Person[] person2 = new Person[3];
            person2[0] = new Person("Иванов В.А.", 30);
            person2[1] = new Person("Саратин И.Н.", 35);
            person2[2] = new Person("Волгин В.А.", 34);

            company1.Departments[1].Persons = person2;

            Person[] person3= new Person[4];
            person3[0] = new Person("Савор М.С.", 25);
            person3[1] = new Person("Фывавич В.С.", 50);
            person3[2] = new Person("Игнатов С.В.", 30);
            person3[3] = new Person("Еваныч В.А.", 36);

            company1.Departments[2].Persons = person3;

            #endregion


            




            
            
            company1.GetInfoCompany();
            





            Console.ReadLine();

        }
    }
}
