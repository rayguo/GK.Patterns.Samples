using System;

namespace FactoryExample
{
    static class AnimalCreator
    {
        public static Animal Create(string type)
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
