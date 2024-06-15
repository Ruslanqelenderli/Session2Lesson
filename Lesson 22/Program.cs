namespace Lesson_22
{
    internal class Program
    {
        delegate void MyDelegate(int x);


        public static void Print(int x)
        {
            Console.WriteLine(x);
        }
        public static void Print2x(int x)
        {
            Console.WriteLine(2*x);
        }

        public static int Calculate(int x)
        {
            return x;
        }

        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Print);

            //myDelegate = Print2x;

            //Func<int, int> del = new Func<int, int>(Calculate);

            //var list = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9
            //};

            //var result = list.Where(x => x > 7).ToList();

            //var result = WhereCondition(list,delegate(int x)
            //{
            //    if (x > 7)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //});

            //foreach (int x in result)
            //{
            //    Console.WriteLine(x);
            //}
            //del(12);

            //myDelegate(12);

            //Predicate<int> predicate = new Predicate<int>(x => x > 7);

            //Func<int, bool> del = new Func<int, bool>(x => x > 7);

            //var result = MyExtension.GetFullName(new User()
            //{
            //    Name = "Test",
            //    Surname = "Test2",
            //});

            //User user = new User()
            //{
            //    Name = "Ruslan",
            //    Surname = "Galandarli"
            //};

            //var result = user.GetFullName(false);
            //HttpClient client = new HttpClient();
            //var result = client.ClientExample();
            //Console.WriteLine(result);

            UserManager  userManager = new UserManager();
            userManager.Add(new User()
            {
                Name = "Ruslan",
                Surname = "Galandarli"
            });
            userManager.Add(new User()
            {
                Name = "test",
                Surname = "test"
            });

            var users = userManager[1];
            Console.ReadLine();
        }

        public static List<int> WhereCondition(List<int> data,Func<int,bool> del)
        {
            var list = new List<int>();
            foreach (var item in data)
            {
                if (del(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
