using Lesson_16.Manage.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16.Manage.Concrete
{
    public class HotMailService : IEmailService
    {
        public void SendEmail(string email)
        {
            Console.WriteLine("Hotmail sended" + email);
        }
    }
}
