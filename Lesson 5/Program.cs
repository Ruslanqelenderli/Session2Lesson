namespace Lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // + , - , * , / , % , ++ , --


            //int a = 13; int b = 6;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);
            //Console.WriteLine(a++);
            //Console.WriteLine(a);
            //Console.WriteLine(b--);
            //Console.WriteLine(b);
            //Console.WriteLine(++a);
            //Console.WriteLine(--b);

            //Console.ReadLine();

            // == , != , > , < , <= ,>= 

            //int.Parse();

            //var res = 65 > 78 || false || 100 % 15 != 0 && false || !false;
            //var res =150+680-1001>0 && 10*10 == 0 || !true && true || false || 90-80>100 &&true;
            int a = 5;
            var res =1024 > int.MinValue && 4>=4  || a++ == 6 || !true && 7>6 || !true;
            Console.WriteLine(res);
            Console.ReadLine(); 

            //var res = 6 >= 6;

            // && , || , ! 


            //var result = !(5==5); 


        }
        private static void Calculate(int x, int y)
        {

            //int a;
            //a = null;
            //int? b;
            //b = null;
            //b.HasValue)

            //int num1 = int.MaxValue;

            //int num3 = int.Parse(Console.ReadLine());
            //int num2 = num1 + num3;

            //Console.ReadLine();

            //double.Parse("2.323");
            //byte.Parse();
            Console.WriteLine(Convert.ToInt32(3.77));
            Console.ReadLine();

            object num = new object();


            /* 
            
            int num1 = 260;
            byte num2 = (byte)num1;
            //Console.WriteLine(num2);    

            Console.WriteLine("int: "+int.MaxValue);
            Console.WriteLine("long: "+long.MaxValue);


            //long num1 = 5;
            //int num2 = (int) num1;
            //long num2 = num1;
            Console.WriteLine("Hello, World!");
            */
        }
    }
}
