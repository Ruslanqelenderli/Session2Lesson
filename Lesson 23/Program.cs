namespace Lesson_23
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            //Console.WriteLine(DateTime.Now);
            //thread.CurrentCulture = new System.Globalization.CultureInfo("az");
            //Console.WriteLine(DateTime.Now);
            //thread.Name = "Main";
            //Console.WriteLine(thread.Name);
            //
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine(i);
            //    Thread.Sleep(1000);
            //}

            //File.WriteAllText("/","test");
           // var response = File.WriteAllTextAsync("/","test");
           User user = new User();
            var response = user.Method2Async();
            Thread thread = new Thread(new ThreadStart(Method2));

            thread.Start();

            Method1();

           var res = await response;

            
            Console.ReadLine();
        }


        public static void Method1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Method2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
