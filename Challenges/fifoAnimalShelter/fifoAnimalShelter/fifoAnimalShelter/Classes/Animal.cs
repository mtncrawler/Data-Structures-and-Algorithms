using System;
using System.Collections.Generic;
using System.Text;

namespace fifoAnimalShelter.Classes
{
    public class Animal
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Animal Next { get; set; }

    }
}
