using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Lesson_14
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Teacher teacher = new Teacher()
            //{
            //    Name = "Ruslan",
            //    Surname = "Galandarli",
            //    Age = 23,
            //    Students = new Student[]
            //    {
            //        new Student
            //        {
            //            Id = 1,
            //            Name = "Vahid"
            //        },
            //        new Student
            //        {
            //            Id = 2,
            //            Name = "Gültən" 
            //        },
            //        new Student
            //        {
            //            Id=3,
            //            Name = "Kənan"
            //        },
            //        new Student
            //        {
            //            Id=4,
            //            Name = "Ləman"
            //        },
            //        new Student
            //        {
            //            Id=5,
            //            Name = "Vahid"
            //        }
            //    }
            //};
            //Teacher teacher2 = new Teacher()
            //{
            //    Name = "Ruslan",
            //    Surname = "Galandarli",
            //    Age = 23,
            //    Students = new Student[] {} 
            //};


            //var jsonResult = JsonConvert.SerializeObject(teacher2,Formatting.Indented);




            //Console.WriteLine(jsonResult);


            var url = "https://randomuser.me/api/";

            //using(var client = new HttpClient())
            //{
            //    var response = await client.SendAsync(new HttpRequestMessage()
            //    {
            //        RequestUri = new Uri(url),
            //        Method = HttpMethod.Get
            //    });

            //    //var stringData = await response.Content.ReadAsStringAsync();
            //    var stringData = JsonConvert.SerializeObject(response.Content.ReadFromJsonAsync<Person>(),Formatting.Indented);
            //    Console.WriteLine(stringData);  

            //    var data = JsonConvert.DeserializeObject<Person>(stringData);

            //    Console.WriteLine(stringData);
            //}

            //Student student = new Student()
            //{
            //    Name = "Test",
            //};
            //Console.WriteLine(student.Name);
            //var student2 = student;
            //student2.Name = "Test2";
            //Console.WriteLine($"Student {student.Name}");
            //Console.WriteLine($"Student2 {student2.Name}");

           
            StudentStruct student = default;
            student.Name = "Test";
            Console.WriteLine(student.Name);

            var student2 = student;
            student2.Name = "Test2";
            Console.WriteLine(student.Name);
            Console.WriteLine(student2.Name);

            Teacher teacher = new Teacher();
            






            Console.ReadLine();
        }
    }
}
