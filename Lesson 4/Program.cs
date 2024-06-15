namespace Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;

            int number3;
            int number2;
            byte by1 = 33;
            byte by2 = 54;

            int by3 = by2 + by1;

            // float , double, decimal
            float num5 = 63.233F;
            double num6 = 4242.4242;

            decimal num7 = 3211.3213M;

            bool num8 = 8 > 7 && 6>7;

            var num9 = 45;
            char num10 = 'A';
            char num11 = 'B';
            var num12 = num10.ToString() + num11.ToString();

            string num13 = "Hello world";


            int a = 5;
            double b = 2.232;
            var s  = a + b;

            Console.WriteLine(num12);
            Console.ReadLine();
        }
    }
}
