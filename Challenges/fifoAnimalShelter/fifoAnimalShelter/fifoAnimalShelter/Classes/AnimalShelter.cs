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

        /// <summary>
        /// add animal to the front of the animal shelter queue
        /// </summary>
        /// <param name="animal">animal to be added</param>
        public void Enqueque(Animal animal)
        {
            Rear.Next = animal;
            Rear = animal;
        } 

        public Animal Dequeue()
        {
                Animal temp = Front;
                Front = Front.Next;
                temp.Next = null;

                return temp;
        }
    }
}
