using System;
using System.Collections.Generic;
using System.Text;

namespace fifoAnimalShelter.Classes
{
    class Animal
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Animal Next { get; set; }

    }
}
