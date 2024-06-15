using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_22
{
    public class UserManager
    {
        private readonly List<User> users;


        public UserManager()
        {
            users = new List<User>();
        }

        public void Add(User user)
        {
            users.Add(user);

        }

        public List<User> Get()
        {
            return users;
        }

        public User this[int index]
        {
            get => users[index];
            set => users[index] = value; 
        }


    }
}
