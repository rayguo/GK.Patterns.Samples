using System;

namespace FactoryExample
{
    abstract class BasicAnimalFactory
    {
        public abstract Animal Create(string type);
    }
}
