namespace Lesson_14
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Surname { get; set; }


        public int Age { get; set; }
        public Student[] Students{ get; set; }
        public int? value;
       

    }

    public struct StudentStruct : IStudent
    {
        public string Name { get; set; }
    }

    public interface IStudent
    {

    }
}
