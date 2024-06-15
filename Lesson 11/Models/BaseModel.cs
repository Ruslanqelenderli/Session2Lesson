using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11.Models
{
    public abstract class BaseModel
    {

        public BaseModel(int id)
        {
           this.id = id;
        }

        public BaseModel(int id,string name)
        {
            this.id = id;
        }
        public int id;

        public void Speak()
        {
            Console.WriteLine("Base model is speaking");
        }

        public bool isDeleted;
        public DateTime createdDate;
        public DateTime? updatedDate;

    }
}
