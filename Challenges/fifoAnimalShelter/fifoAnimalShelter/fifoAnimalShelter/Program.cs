using System;
using fifoAnimalShelter.Classes;

namespace fifoAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Animal doggo = new Animal { Type = "dog", Name = "Bob" };
            Animal puppers = new Animal { Type = "dog", Name = "Roger" };
            Animal kittie = new Animal { Type = "cat", Name = "Zeus" };

            AnimalShelter animalShelter = new AnimalShelter(doggo);
            animalShelter.Enqueque(puppers);
            animalShelter.Enqueque(kittie);

            Console.WriteLine(animalShelter.Front.Name);

        }
    }
}
