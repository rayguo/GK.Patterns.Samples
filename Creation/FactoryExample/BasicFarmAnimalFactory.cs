using System;

namespace FactoryExample
{
    // Deriving from abstract base class adds extensibility,
    // with creation depending on derived class

    class BasicFarmAnimalFactory : BasicAnimalFactory
    {
        public override Animal Create(string type)
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
