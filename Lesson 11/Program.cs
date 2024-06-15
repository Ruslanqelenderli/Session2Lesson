using Lesson_11.Models;

namespace Lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student(12);

            //student.Speak();

            BaseModel baseModel = new Student(12);

            Student student =new Student(13);

            student.Speak();

            baseModel.Speak();

            //BaseModel baseModel = new Student(12,12);




            //Teacher teacher = new Teacher("Ruslan");

            //Teacher.salary = 500;
            //Teacher teacher1 = new Teacher();
            //Teacher teacher2 = new Teacher();
            //Teacher teacher3 = new Teacher();

            

            //teacher1.name = "Ruslan";
            //teacher1.GetTeacherInfo();
            
            //teacher2.name = "Vahid";
            //teacher2.GetTeacherInfo();

            //Teacher.salary = 600;
            //teacher1.GetTeacherInfo();
            //teacher2.GetTeacherInfo();


            //teacher3.name = "Elemdar";
            //Teacher.salary = 500;
            //Teacher.GetStaticInfo();
            //Console.WriteLine("Hello, World!");
        }
    }


    //public class Teacher
    //{
    //    public string name;
    //    public string surname;

    //    public void GetTeacherInfo()
    //    {
    //        Console.WriteLine($"{name} {surname} {salary}");
    //    }

    //    public static void GetStaticInfo()
    //    {
    //        Console.WriteLine($"{salary}");
    //    }

    //    public static double salary;
    //}
    
}
