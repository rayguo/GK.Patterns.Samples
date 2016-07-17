using System;

namespace FactoryExample
{
    // Base class delegates creation to derived class,
    // after pre and post creation processing.

    class FarmAnimalFactory : AnimalFactory
    {
        protected override Animal InternalCreate(string type)
        {
            Animal animal = null;

            switch (type.ToLower())
            {
                case "dog":
                    animal = new Dog();
                    break;
                case "chicken":
                    animal = new Chicken();
                    break;
                case "cow":
                    animal = new Cow();
                    break;
                case "sheep":
                    animal = new Sheep();
                    break;
            }
            return animal;
        }
    }
}
