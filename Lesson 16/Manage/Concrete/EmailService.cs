using Lesson_16.Manage.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16.Manage.Concrete
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string email)
        {
            Console.WriteLine("Email sended to "+email);
        }
    }
}
