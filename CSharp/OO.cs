using System;

namespace OO
{
    public class Dog
    {
        public void latir()
        {
            Console.WriteLine("Au au!");
        }
    }

    class OO
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.latir();
        }
    }
}
