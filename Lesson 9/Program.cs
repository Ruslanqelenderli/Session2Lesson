namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Sum(2,23,32,43);

            //var result = false || false || 5 > 5 && 6 == 6 || 7 >= 3 && 11 != 0;

            //var result = true && 110 - 56 > 50 && 18 % 5 != 3 && true && 170 > 8;

            var result = 170 / 8 == 22 && true || 186 > 180 && !(11 > 12);



            Console.WriteLine(result);
            Console.ReadLine(); 
        }


        private static void Sum(int x)
        {
            Console.WriteLine($"Sum1");
        }

        private static void Sum(int result,int result2,int result3,int result4)
        {
            Console.WriteLine($"Sum2");

        }
    }
} 
