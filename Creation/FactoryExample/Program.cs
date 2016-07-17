using System;

namespace FactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseAnimalCreator();
            //UseBasicFactory();
            //UseOtherFactory();
        }

        private static void UseOtherFactory()
        {
            var factory = new FarmAnimalFactory();
            var animal = factory.Create("cow");
            animal.Speak();
        }

        private static void UseBasicFactory()
        {
            var factory = new BasicFarmAnimalFactory();
            var animal = factory.Create("cow");
            animal.Speak();
        }

        private static void UseAnimalCreator()
        {
            Animal animal = AnimalCreator.Create("cow");
            animal.Speak();
        }
    }
}
