using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    public class Person
    {
        public Result[] Results{ get; set; }
        public  Info Info{ get; set; }
    }

    public class Result
    {
        public string Gender { get; set; }
        public string Email { get; set; }
        public Name Name { get; set; }
    }
    public class Info
    {
        public string Seed { get; set; }
        public int Results { get; set; }
        public int Page { get; set; }
        public string Version { get; set; }
    }
    public class Name
    {
        public string Title { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }
}
