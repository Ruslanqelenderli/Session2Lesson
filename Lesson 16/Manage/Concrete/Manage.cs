using Lesson_16.Entities;
using Lesson_16.Manage.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16.Manage.Concrete
{
    public class Manage 
    {
        private IEmailService _emailService;
        public Manage(IEmailService emailService)
        {
            _emailService = emailService;    
        }
        public  void AddUser()
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                Name = Console.ReadLine(),
                Email = Console.ReadLine()
            };
            _emailService.SendEmail(user.Email);
        }
        public void UpdateUser()
        {

            _emailService.SendEmail("test");
        }

    }
    
}
