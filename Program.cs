using System;

namespace Mod3Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
            
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag());
            
            
            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
            
            myDog.Bark(4);
            Console.WriteLine(myDog.GetTag());


        }
    }
}
