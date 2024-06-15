using System.Runtime.CompilerServices;

namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter first number");
                    n1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            var res = true;
            while (res)
            {
                
                    Console.WriteLine("Please enter second number");

                    var userResult = Console.ReadLine();

                    var isTrueResult = int.TryParse(userResult, out int ress);

                    if (isTrueResult)
                    {
                        n2 = ress;
                        res = false;

                    }
                
            }

            

            int result = Sum(n1, n2);

            Console.WriteLine("Sum is " + result);

            Console.ReadLine();

        }

        private static int Sum(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
    }
}
