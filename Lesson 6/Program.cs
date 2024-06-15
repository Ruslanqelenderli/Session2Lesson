using System.ComponentModel.Design;

namespace Lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DateTime date = DateTime.Now;
            //var ticks = date.DayOfWeek;

            //var dayOfWeek = DayOfWeek.Wednesday;

            //var data = DayOfWeek.Monday.ToString();

            //Console.WriteLine(data);

            //Console.WriteLine("Yaşınızı daxil edin");

            //int age = int.Parse(Console.ReadLine());

            //if(age > 18)
            //{
            //    Console.WriteLine("Ugurlu giris");
            //}
            //else if(age == 18)
            //{
            //    Console.WriteLine("Bir il sonra gelersen");
            //}
            //else
            //{
            //    Console.WriteLine("Senin yasin catmir");
            //}
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 10:
                    Console.WriteLine(10);
                    break;
                case 6:
                    Console.WriteLine(6);
                    break;
                case 7: 
                    Console.WriteLine(7);
                    break;
                default: 
                    Console.WriteLine("data not found");
                    break;
            }
            Console.ReadLine(); 
        }
    }
}
