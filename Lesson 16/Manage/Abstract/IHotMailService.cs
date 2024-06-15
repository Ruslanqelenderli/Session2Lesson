using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16.Manage.Abstract
{
    public interface IHotMailService
    {
        void SendEmail(string email);   
    }
}
