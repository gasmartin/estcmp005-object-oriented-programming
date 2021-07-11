using System;

namespace Constructor
{
    public class Dog
    {
        public string nome;

        public Dog(string nome)
        {
            this.nome = nome;
        }

        public void display()
        {
            Console.WriteLine($"{this.nome} está te dando oi. Au!");
        }
    }

    class Constructor
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Noah");
            dog.display();
        }
    }
}
