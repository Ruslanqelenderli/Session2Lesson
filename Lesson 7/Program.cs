namespace Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //for


            //for (int i = 0; i < 4; i++)
            //{

            //    //if(i< 60 && i > 30)
            //    //{
            //    //    continue;
            //    //}

            //    //if (i == 50)
            //    //{
            //    //    break;
            //    //}
            //    Console.WriteLine(arr[i]);

            //    //
            //}

            //while

            //int i = 0;

            //while(i<100) 
            //{
            //    Console.WriteLine("Ruslan");

            //    i += 2;
            //}

            //while (false)
            //{
            //    Console.WriteLine("Ruslan");
            //}


            //do while 


            //do
            //{
            //    Console.WriteLine("Ruslan");
            //}
            //while (true);

            //int num = 3;
            //foreach (var data in num)
            //{

            //}

            //{1,2,3,4}

            //foreach

            //foreach (int value in arr)
            //{
            //    Console.WriteLine(value);
            //}


            //array

            //int value = 4;
            //string s = "Ruslan";

            //var result = s.ToArray();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);    
            //}
            //int[] arr = new int[5];

            //arr[0] = 3;
            //arr[1] = 4;
            //arr[2] = 7;
            //arr[3] = 1;
            //arr[4] = 218;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //arr = arr.OrderByDescending(x=>x).ToArray();

            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //var maxValue = arr.Max();   
            //var minValue = arr.Min();

            //Console.WriteLine("Max value is " + maxValue + ", Min value is "+ minValue);
            //Console.WriteLine($"Max value is {maxValue} , Min value is {minValue}");

            /*
             
            *
            **
            ***
            ****
            
             
             */

            while (true)
            {
                Console.WriteLine("Tek ededi daxil edin");
                var result = int.TryParse(Console.ReadLine(), out int val);
                if (result)
                {
                    if (val % 2 != 0)
                    {
                        for (int i = 0; i < val; i++)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Number daxil edin");
                }

            }
            



            Console.ReadLine();

            Console.WriteLine("Hello, World!");
        }
    }
}
