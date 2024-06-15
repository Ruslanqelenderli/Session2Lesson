using System.ComponentModel;

namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] arr1 = new int[5];
            //arr1[0] = 10;
            //arr1[1] = 20;
            //arr1[2] = 30;
            //arr1[3] = 40;
            //arr1[4] = 50;

            //int sum = 0;

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    //sum = sum + arr1[i];
            //    sum += arr1[i];
            //}
            //Console.WriteLine("Sum = " +sum);


            //int[,,] arr3 = new int[3, 3, 3];

            //int[,] arr2 = new int[2, 2];
            //arr2[0, 0] = 10;
            //arr2[0, 1] = 20;
            //arr2[1, 1] = 30;
            //arr2[1, 0] = 40;
            //int sum = 0;
            //int xSize = arr2.GetLength(0);
            //int ySize = arr2.GetLength(1);
            //Console.WriteLine(arr2.Rank);
            //for (int i = 0; i < xSize; i++)
            //{
            //    for (int j = 0; j < ySize; j++)
            //    {
            //        sum += arr2[i,j];
            //    }

            //}

            //Console.WriteLine(sum);

            //var result = SumArray2(arr2,"str",true);

            //Console.WriteLine(result);

            //var a = Console.ReadLine();

            //var b = Console.ReadLine();

            //var c = Console.ReadLine();

            //var result = Sum(a, b, c);

            //Sum2(1,2,3,4,5);
            //Console.WriteLine(result);


            PlusOne(out int a);
            Console.WriteLine(a);


            Console.ReadLine();


            Console.WriteLine("Hello, World!");
        }
        
        static int PlusOne(out int a)
        {

            a = 5;
            return a;
        }

        static void SumArray(int[,] arr2)
        {
            var sum = 0;
            int xSize = arr2.GetLength(0);
            int ySize = arr2.GetLength(1);
            Console.WriteLine(arr2.Rank);
            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                {
                    sum += arr2[i, j];
                }

            }

            Console.WriteLine(sum);
        }

        static int SumArray2(int[,] arr2,string str,bool result)
        {
            int sum = 0;
            int xSize = arr2.GetLength(0);
            int ySize = arr2.GetLength(1);
            Console.WriteLine(arr2.Rank);
            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                {
                    sum += arr2[i, j];
                }

            }

            if (sum < 101)
            {
                return sum;
            }
            else
            {
                return 0;
            }



        }

        static int Sum(string a,string b,string c)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            var num1Result = CheckResult(a);
            if (num1Result.result) num1 = num1Result.val;
            var num2Result = CheckResult(b);
            if (num2Result.result) num2 = num2Result.val;
            var num3Result = CheckResult(c);
            if (num3Result.result) num3 = num3Result.val;

            return num1 + num2 + num3;

        }

        static void Sum2(params int[] param)
        {
            int sum = 0;
            for(int i = 0;i < param.Length; i++)
            {
                sum += param[i];
            }
            Console.WriteLine(sum);
        }


        static (bool result,int val) CheckResult(string value)
        {
            try
            {
                var res = int.Parse(value);
                return (true, res);
            }
            catch (Exception)
            {
                return (false, 0);
            }

        }


    }
}
