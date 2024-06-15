

namespace Lesson_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //public, private, protected, internal, protected internal,private protected
            //Animal animal = new Animal();
            //Dog dog = new Dog();    
            //Console.WriteLine("Hello, World!");

            //Animal animal = new Animal();   
            //Dog dog = new Dog();
            //Animal animal1 = new Dog();



            //animal.Speak();
            //dog.Speak();
            //animal1.Speak();


            //animal.Move();
            //dog.Move();
            //animal1.Move();

            Animal[] animals = new Animal[3];
            animals[0] = new Animal();
            animals[1] = new Dog();
            animals[2] = new Husky();


            foreach (var animal in animals)
            {

                //var husky = (Husky) animal;

                //if(animal is Husky)
                //{

                //    var husky = animal as Husky;

                //    husky.name = "Garip";
                //}

               var husky = animal as Husky;
                if( husky != null)
                {
                    husky.name = "Garip";

                }

                Console.WriteLine(true);

                Animal animal2 = new Dog();

                var dog = animal as Dog;
                var dog1 = (Dog)animal;
                dog.Move();
                animal2.Move();
                animal.Speak();
            }



            Console.ReadLine();
        }
    }
}
