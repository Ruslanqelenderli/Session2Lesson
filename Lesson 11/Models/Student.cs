using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11.Models
{
    internal class Student : BaseModel
    {
        public Student(int ids) : base(ids)
        {
            
        }
        public string name;

        public new void Speak()
        {
            Console.WriteLine("Student is speaking");
        }
    }
}
