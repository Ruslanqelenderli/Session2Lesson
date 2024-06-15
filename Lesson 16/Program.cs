using Lesson_16.Entities;
using Lesson_16.Manage.Abstract;
using Lesson_16.Manage.Concrete;

namespace Lesson_16
{
    internal class Program
    {
        public static User[] Users= new User[5];
        static void Main(string[] args)
        {
            byte index = 0;
            var result = "";
            while (result!="1")
            {
                Manage.Concrete.Manage manage = new Manage.Concrete.Manage(new HotMailService());
                manage.AddUser();
                result = Console.ReadLine();
            }

            Console.WriteLine("Hello, World!");
        }

        


    }
}
