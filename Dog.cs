using System;

namespace Mod3Dog
{
    public enum Gender
    {
        Male,
        His,
        he, 
        Female,
        Her,
        she
    }
    public class Dog
    {
        public string name;
        public string owner;
        public int age;
        public Gender gender;
        
        public Dog(string name, string owner, int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }
        public void Bark(int barks)
        {
            for (int i = 0; i < barks; i++)
            {
                Console.Write("Woof! ");
            }
        }
        public string GetTag()
        {
            if (age > 1)
            {
                return $"\nIf lost, call {owner}. {gender + 1} name is {name} and {gender + 2} is {age} years old.";
            }
            else
            {
                return $"\nIf lost, call {owner}. {gender + 1} name is {name} and {gender + 2} is {age} year old.";
            }
            
        }
    }
}