using System;
using System.Collections;

namespace Aggregation
{
    class Furniture
    {
        public string Nome { get; set; }

        public Furniture(string nome)
        {
            Nome = nome;
        }
    }

    class Room
    {
        public ArrayList Furnitures { get; set; }

        public Room()
        {
            Furnitures = new ArrayList();
        }

        public void addFurniture(Furniture furniture)
        {
            if(Furnitures.Contains(furniture)) return;
            Furnitures.Add(furniture);
        }

        public void addFurniture(params Furniture[] furnitures)
        {
            foreach (Furniture furniture in furnitures)
            {
                addFurniture(furniture);
            }
        }

        public void showFurnitures()
        {
            foreach(Furniture furniture in Furnitures)
            {
                Console.WriteLine(furniture.Nome);
            }
        }
    }

    class Aggregation
    {
        static void Main(string[] args)
        {
            Room room = new Room();

            Furniture cadeira = new Furniture("Cadeira");
            Furniture mesa = new Furniture("Mesa");
            Furniture armario = new Furniture("Armario");

            room.addFurniture(cadeira);
            room.addFurniture(mesa, armario);

            room.showFurnitures();

            room = null; // Deletando a sala

            // As mobilias continuam existindo
            Console.WriteLine(cadeira.Nome);
            Console.WriteLine(mesa.Nome);
            Console.WriteLine(armario.Nome);

            Console.ReadLine();
        }
    }
}
