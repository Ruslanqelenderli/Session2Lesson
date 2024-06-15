using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Teymur","Mustafayev",2010);

            Person person2 = new Person();
            person2.birthdate = 2000;
            person2.name = "Eli";
            person2.surname = "Eliyev";

            person2.PrintPersonInfo(); 
            person2.PrintPersonAge();
            //person1.name = "Ruslan";
            //person1.surname = "Galandarli";
            //person1.birthdate = 2001;


            person1.PrintPersonInfo();
            person1.PrintPersonAge();


            Person person3 = new Person(1999);

            Console.WriteLine("Hello, World!");
        }
    }

    class Person
    {

        public Person()
        {

        }


        public Person(int date)
        {
            Console.WriteLine($"{date}");
        }
        public Person(string name2,string surname2,int birthdate2)
        {
            this.name = name2;
            this.surname = surname2;
            this.birthdate = birthdate2;
        }
        public string name;
        public string surname;
        public int birthdate;

        public void PrintPersonInfo()
        {
            var info = $"My name is {name}, my surnime is {surname}, my birthdate is {birthdate}.";
            Console.WriteLine (info);   
        }


        public void PrintPersonAge()
        {
            var age = DateTime.Now.Year - birthdate;
            Console.WriteLine (age);    
        }
    
        ~Person() 
        {
        }
    }
}
