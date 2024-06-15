using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2;

namespace Lesson_12
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaking");
        }

        public void Move()
        {
            Console.WriteLine("Animal moving");
        }
    }
}
