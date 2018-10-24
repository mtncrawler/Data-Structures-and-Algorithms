using System;
using System.Collections.Generic;
using System.Text;

namespace fifoAnimalShelter.Classes
{
    public class AnimalShelter
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

        /// <summary>
        /// remove the animal that was put into the shelter first
        /// </summary>
        /// <param name="preference">specifies dog or cat to remove</param>
        /// <returns>removed animal</returns>
        public Animal Dequeue(string preference)
        {
            if (preference.ToLower() != "dog" || preference.ToLower() != "cat")
            {
                Animal temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp;
            }

            while (Front != null)
            {
                Animal temp = Front;
                
                if (temp.Type == preference)
                {
                    Front = Front.Next;
                    temp.Next = null;
                    return temp;
                }
                else
                {
                    Front = Front.Next;
                    temp.Next = null;
                    Enqueque(temp);
                }
            }

            return Front;
        }
    }
}
