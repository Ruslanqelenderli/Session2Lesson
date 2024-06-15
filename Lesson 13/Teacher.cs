using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    public class Teacher
    {
        private string name;
        public string surname;
        private string gender;

        public string Gender {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public int age;
        public bool hasAccess;

        public Teacher(int age)
        {
            this.age = age;
            if (age > 18)
            {
                hasAccess = true;   
            }
            else
            {
                hasAccess = false;  
            }
        }
        public void SetName (string name)
        {
            if (name.Length > 5)
            {
                this.name = name;
            }   
        }

        public string GetName()
        {
            if (hasAccess)
            {
                return this.name;
            }
            return "You dont have access";
        }
    }
}
