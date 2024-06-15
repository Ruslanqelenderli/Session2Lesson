namespace Lesson_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 3 ededi daxil edin!");
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < 3; i++)
            {

                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    if (a >= max)
                    {
                        max = a;
                    }
                    if (a <= min)
                    {
                        min = a;
                    }
                }

            }
            Console.WriteLine($" Minimum eded: {min}, Maximum eded: {min}");
        }
    }
}
