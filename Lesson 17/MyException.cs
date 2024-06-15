using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17
{
    public class MyException:Exception
    {
        public MyException(string message, Exception ex):base(message,ex)
        {
            
        }
    }
}
