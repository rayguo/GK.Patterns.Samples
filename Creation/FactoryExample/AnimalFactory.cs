using System;

namespace FactoryExample
{
    abstract class AnimalFactory
    {
        public Animal Create(string type)
        {
            // Do something before creation
            Animal animal = InternalCreate(type);
            // Do something after creation
            return animal;
        }

        protected abstract Animal InternalCreate(string type);
    }
}
