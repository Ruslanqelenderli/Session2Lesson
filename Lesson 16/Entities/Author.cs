using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public override DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Move()
        {
            Console.WriteLine("Authot Move");
        }
    }
}
