using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    public class Dog:Animal
    {
        public override void Speak()
        {
            Console.WriteLine("hav-hav");
        }

        public new void Move()
        {
            Console.WriteLine("Dog moving");
        }
    }
}
