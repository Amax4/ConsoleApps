using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.OOP.AbstractionInheritancePolymorphism
{
    abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("Zzzzz");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    internal class Animals
    {
        public static void Act()
        {
            Utils.CleanUpConsole();

            List<Animal> animals = new List<Animal>
            {
                new Dog(),
                new Cat(),
            };

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
                animal.Sleep();
            }

            Utils.WaitForAnyInput();
        }
    }
}