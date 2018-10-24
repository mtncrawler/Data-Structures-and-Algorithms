using System;
using Xunit;
using fifoAnimalShelter.Classes;


namespace fifoAnimalShelterTest
{
    public class UnitTest1
    {
        /// <summary>
        /// test a dog is added
        /// </summary>
        [Fact]
        public void DogIsAdded()
        {
            Animal doggo = new Animal { Type = "dog", Name = "Bob" };
            Animal puppers = new Animal { Type = "dog", Name = "Roger" };

            AnimalShelter animalShelter = new AnimalShelter(doggo);
            animalShelter.Enqueque(puppers);

            Assert.Equal(puppers.Type, animalShelter.Rear.Type);
        }

        /// <summary>
        /// test that a cat is added
        /// </summary>
        [Fact]
        public void CatIsAdded()
        {
            Animal doggo = new Animal { Type = "dog", Name = "Bob" };
            Animal kittie = new Animal { Type = "cat", Name = "Zeus" };

            AnimalShelter animalShelter = new AnimalShelter(doggo);
            animalShelter.Enqueque(kittie);

            Assert.Equal(kittie.Type, animalShelter.Rear.Type);
        }

        /// <summary>
        /// test that a cat is removed from Rear
        /// </summary>
        [Fact]
        public void CatIsRemovedFromRear()
        {
            Animal doggo = new Animal { Type = "dog", Name = "Bob" };
            Animal puppers = new Animal { Type = "dog", Name = "Roger" };
            Animal kittie = new Animal { Type = "cat", Name = "Zeus" };

            AnimalShelter animalShelter = new AnimalShelter(doggo);
            animalShelter.Enqueque(puppers);
            animalShelter.Dequeue("cat");

            Assert.True(kittie.Name != animalShelter.Rear.Name);
        }

        /// <summary>
        /// test that a dog is removed from the middle
        /// </summary>
        [Fact]
        public void DogIsRemovedFromMiddle()
        {
            Animal doggo = new Animal { Type = "dog", Name = "Bob" };
            Animal puppers = new Animal { Type = "dog", Name = "Roger" };
            Animal kittie = new Animal { Type = "cat", Name = "Zeus" };

            AnimalShelter animalShelter = new AnimalShelter(kittie);
            animalShelter.Enqueque(puppers);
            animalShelter.Enqueque(doggo);
            animalShelter.Dequeue("dog");

            Assert.True(puppers.Name != animalShelter.Front.Next.Name);
        }

        /// <summary>
        /// test for unspecified animal is removed
        /// </summary>
        [Fact]
        public void FirstAnimalIsRemoved()
        {
            Animal doggo = new Animal { Type = "dog", Name = "Bob" };
            Animal kittie = new Animal { Type = "cat", Name = "Zeus" };

            AnimalShelter animalShelter = new AnimalShelter(doggo);
            animalShelter.Enqueque(kittie);
            animalShelter.Dequeue("hippo");

            Assert.Equal(kittie.Name, animalShelter.Front.Name);
        }
    }
}
