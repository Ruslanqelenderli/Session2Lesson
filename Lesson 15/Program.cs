namespace Lesson_15
{
    internal class Program
    {
        public static User[] Users = new User[100];
        public static string direction = @"C:\Users\User\Desktop\Db";
        static void Main(string[] args)
        {
            var index = 0;

            while (true)
            {
                Console.WriteLine("If you want to create user press 1, if you see all users press 2,If you want to close program press 0.");

                var command = Console.ReadLine();

                if (command == "0") break;

                switch (command)
                {
                    case "1":
                        {
                            CreateUser(index);
                            index++;
                            break;
                        }
                    case "2":
                        {
                            GetUsers();
                            break;
                        }

                }

            }

            Console.ReadLine();
        }

        public static void CreateUser(int index)
        {
            var id = Guid.NewGuid();
            Console.WriteLine("Insert Name");
            var name = Console.ReadLine();

            Console.WriteLine("Insert Surname");
            var surname = Console.ReadLine();
            var fileName = id + ".txt";
            var filePath = Path.Combine(direction, fileName);
            //if(File.Exists(filePath))
            //{

            //}
            var content = $"Id = {id} \n" +
                    $"Name = {name} \n" +
                    $"Surname = {surname} \n";
            File.WriteAllText(filePath, content);



            //var user = new User()
            //{
            //    Id = id,
            //    Surname = surname,
            //    Name = name
            //};
            //Users[index] = user;
        }

        public static void GetUsers()
        {
            //foreach (var user in Users)
            //{
            //    if (user == null) break;
            //    Console.WriteLine($"Id = {user.Id} \n" +
            //        $"Name = {user.Name} \n" +
            //        $"Surnam = {user.Surname} \n");
            //}

            var directory = new DirectoryInfo(direction);
            var files = directory.GetFiles();

            foreach (var file in files)
            {
                var fileLines = File.ReadAllLines(file.FullName);
                var id = fileLines[0].Split('=')[1].Trim();
                var name = fileLines[1].Split('=')[1].Trim();
                var surname = fileLines[2].Split('=')[1].Trim();
                Console.WriteLine($"Id = {id} \n" +
                    $"Name = {name} \n" +
                    $"Surnam = {surname} \n");
            }
        }
    }
}
