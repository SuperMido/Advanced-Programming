using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }

    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("weeping...");
        }
    }

    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("meowing...");
        }
    }

    public class RandomList : List<string>
    {
        private Random randomElement;

        public string RandomString()
        {
            int pos;
            pos = randomElement.Next(0, Count);
            string element = this[pos];
            RemoveAt(pos);
            return element;
        }
    }

    public class StackOfStrings
    {
        private List<string> data;
        public void Push(string item)
        {
            data.Add(item);
        }

        public string Pop()
        {
            string item = data[data.Count -1];
            data.RemoveAt(data.Count -1);
            return item;
        }

        public string Peek()
        {
            return data[data.Count -1];
        }

        public bool IsEmpty()
        {
            if(data.Count ==0) return true;
            else return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Bark();

            // Puppy myPyppy = new Puppy();
            // myPyppy.Eat();
            // myPyppy.Bark();
            // myPyppy.Weep();

            Cat myCat = new Cat();
            myCat.Eat();
            myCat.Meow();
        }
    }
}
