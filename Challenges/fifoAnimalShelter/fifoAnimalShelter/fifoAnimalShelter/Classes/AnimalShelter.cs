using System;
using System.Collections.Generic;
using System.Text;

namespace fifoAnimalShelter.Classes
{
    class AnimalShelter
    {
        public Animal Front { get; set; }

        public Animal Rear { get; set; }

        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
        }

        public void Enqueque(Animal animal)
        {
            Rear.Next = animal;
            Rear = animal;
        } 

    }
}
