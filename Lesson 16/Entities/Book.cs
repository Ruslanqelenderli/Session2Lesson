using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public override DateTime CreatedDate { get; set; }

        public override void Move()
        {
            Console.WriteLine("Book Move");
        }
    }
}
