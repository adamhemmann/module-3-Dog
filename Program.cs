using System;

namespace Mod3Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Dog.Gender.Male);
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag());
            //puppy.GenderTest();

            Dog myDog = new Dog("Lileu", "Dale", 4, Dog.Gender.Female);
            myDog.Bark(4);
            Console.WriteLine(myDog.GetTag());


        }
    }
}
