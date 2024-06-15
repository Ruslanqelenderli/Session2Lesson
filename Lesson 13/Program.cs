using System.Net.Http.Json;

namespace Lesson_13
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Teacher teacher = new Teacher();
            //teacher.surname = "test2";
            //var surname = teacher.surname;  
            //teacher.SetName("Test");    

            //var name = teacher.GetName();
            //Console.WriteLine(name + " " + surname);

            //Teacher teacher = new Teacher(19);
            //teacher.Gender = "Male";

            try
            {
                bool next = false;
                do
                {
                    using (var client = new HttpClient())
                    {
                        var response = await client.GetAsync("https://official-joke-api.appspot.com/random_joke");

                        var model = await response.Content.ReadFromJsonAsync<Joke>();
                        Console.WriteLine("Setup: " + model.Setup + "\r\n" + "Punchline: " + model.Punchline);
                        Console.WriteLine("If you want to continuous write 1 else write 0");
                        var result = Console.ReadLine();
                        if (result == "1") next = true;
                        else next = false;

                    }

                } while (next);
                
            }
            catch (Exception ex)
            {

                throw;
            }
            

            //Console.WriteLine(teacher.Gender);

            //teacher.SetName("Ruslan");
            //var value = teacher.GetName();
            //Console.WriteLine(value);


            Console.ReadLine(); 
        }
    }
}
