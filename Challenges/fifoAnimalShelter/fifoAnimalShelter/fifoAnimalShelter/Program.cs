using System;
using fifoAnimalShelter.Classes;

namespace fifoAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the FIFO Shelter!");

            FIFOAnimalShelter();
        }

        public static void FIFOAnimalShelter()
        {
            Animal doggo = new Animal { Type = "dog", Name = "Bob" };
            Animal puppers = new Animal { Type = "dog", Name = "Roger" };
            Animal kittie = new Animal { Type = "cat", Name = "Zeus" };

            AnimalShelter animalShelter = new AnimalShelter(doggo);
            animalShelter.Enqueque(puppers);
            animalShelter.Enqueque(kittie);

            Console.WriteLine($"Please adopt {animalShelter.Front.Name}! This dog has been at the shelter the longest.");

            Console.WriteLine("=====CAT IS ADOPTED======");
            Console.WriteLine($"Thank you for adopting {kittie.Name}, she is the cat that has been here the longest!");
            animalShelter.Dequeue("cat");

        }
    }
}
