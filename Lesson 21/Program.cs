using System.Collections.Generic;

namespace Lesson_21
{
    internal class Program
    {
        delegate bool MyDelegate(int number);



        static void Main2(string test) => Console.WriteLine(test);
        static void Main(string[] args)
        {

            
            var list = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19
            };

            var list3 = list.Where(num => num % 3 == 0).ToList();
            ConvertToStringFromList(list3);

            //CalculateLessThan10(list);
            //CalculateMoreThan10(list);
            //CalculateDivide3(list);

            //MyDelegate myDelegate = new MyDelegate(Divide3);

            //var result = myDelegate(12);

            //CalculateDivide(list,number =>
            //{
            //    return number % 3 == 0;
            //});



            //Console.WriteLine(ConvertToStringFromList(list2));
            //var user = new User("Ruslan","Galandarli");

            //Console.WriteLine(user.ToString());
        }

        static void CalculateLessThan10(List<int> list)
        {
            var list2 = new List<int>();

            foreach (int i in list)
            {
                if (i < 10)
                {
                    list2.Add(i);
                }
            }
            ConvertToStringFromList(list2);
        }

        static void CalculateMoreThan10(List<int> list)
        {
            var list2 = new List<int>();

            foreach (int i in list)
            {
                if (i > 10)
                {
                    list2.Add(i);
                }
            }
            ConvertToStringFromList(list2);
        }

        static void CalculateDivide (List<int> list,MyDelegate @delegate)
        {
            var list2 = new List<int>();

            foreach (var item in list)
            {
                if(@delegate(item))
                {
                    list2.Add(item);
                }
            }
            ConvertToStringFromList(list2);
        }

        

        static void ConvertToStringFromList(List<int> list)
        {
            var str = "";
            //var i = 0;
            //foreach (var item in list)
            //{
            //    str += item ;
            //    i++;

            //    if(i != list.Count)
            //    {
            //        str += ",";
            //    }

            //}

            //foreach (int i in list)
            //{
            //    str += i + ",";
            //}

            //str = str.Substring(0,str.Length-1);

            foreach (int i in list)
            {
                str += i + ",";
            }
            str = str.TrimEnd(',');

            Console.WriteLine(str);
        }

    }
}
