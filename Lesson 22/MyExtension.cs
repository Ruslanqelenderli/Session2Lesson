using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_22
{
    public static class MyExtension
    {
        public static string GetFullName(this User user, bool condition)
        {
            if (condition)
            {
                return user.Name + " " + user.Surname;
            }
            else
            {
                return "";
            }
        }

        public static string ClientExample(this HttpClient client)
        {
            return "salam";
        }

    }
}
