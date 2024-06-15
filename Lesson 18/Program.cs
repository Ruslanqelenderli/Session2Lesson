using System.Collections;

namespace Lesson_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            //List
            //Dictionary
            //Queue
            //Stack
            //Hashset

            var hashset1 = new HashSet<int>();

            hashset1.Add(1);
            hashset1.Add(2);
            hashset1.Add(3);
            hashset1.Add(4);

            var hashset2 = new HashSet<int>();

            hashset2.Add(4);
            hashset2.Add(5);
            hashset2.Add(6);
            hashset2.Add(7);

            hashset1.Union(hashset2);
            hashset1.IntersectWith(hashset2);

            var result = true;
            var stringResult = result ? "Yes" : "No";

            //var queue = new Queue();
            //queue.Enqueue(1);

            //var result = queue.Dequeue();

            //var stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //var res = stack.Pop();
            //var ress = stack.Peek();

            //var arr = new int[10];
            //arr[0] = 12;
            //var person1 = new Person()
            //{
            //    Id = 1,
            //    Name = "Ruslan",
            //    Surname = "Galandarli"
            //};
            //var person2 = new Person()
            //{
            //    Id = 2,
            //    Name = "Eli",
            //    Surname = "Agayev"
            //};
            //var list = new List<Person>(); 
            //list.Add(person1);
            //list.Add(person2);

            //var dictionary = new Dictionary<int, Person>();

            //dictionary.Add(person1.Id, person1);
            //dictionary.Add(person2.Id, person2);





            try
            {
                //var list = new ArrayList();
                
                //list.Add(12);
                //list.Add("string");
                //list[1] = "ssdada";

                //Console.WriteLine(list[1]);

                //decimal sum = 0;

                //foreach (var item in list)
                //{
                //    if(item is int)
                //    {
                //        sum += (int)item;

                //    }
                //}
                //Console.WriteLine(sum);


                //var list = new List<int>(); 

            }
            catch (Exception ex)
            {

            }
            


        }

        public class IntData:GenericData<test2,Guid>
        {

        }

        public class StringData:GenericData<Person, double>
        {
        }

        public class DoubleData:GenericData<test2, int>
        {
        }

        public class GenericData<T,TId>
            where T: Person, new()
            
        {
            public TId Id { get; set; }
            public T Data { get; set; }

            public T GetData()
            {
                return Data;
            }

             
        }
        public   class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
        }
        public class test2: Person
        {

        }
    }
}
