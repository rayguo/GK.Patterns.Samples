using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace PrototypeExample
{
    class PrototypeAnimal : Animal, IAnimalPrototype
    {
        private string _type;

        public PrototypeAnimal(string type)
        {
            _type = type;
        }

        public override void Speak()
        {
            switch (_type)
            {
                case "cow":
                    Console.WriteLine("Moo");
                    break;
                case "dog":
                    Console.WriteLine("Woof");
                    break;
                case "chicken":
                    Console.WriteLine("Chick");
                    break;
                case "sheep":
                    Console.WriteLine("Bah");
                    break;
            }
        }

        public override string Type
        {
            get { return _type; }
        }

        public Animal Clone()
        {
            return Clone(this);
        }

        private T Clone<T>(T item)
                where T : class
        {
            using (var stream = new MemoryStream())
            {
                var ser = new JsonSerializer();
                var writer = new BsonWriter(stream);
                ser.Serialize(writer, item);
                stream.Position = 0;
                var reader = new BsonReader(stream);
                var copy = ser.Deserialize<T>(reader);
                return copy;
            }
        }
    }
}
