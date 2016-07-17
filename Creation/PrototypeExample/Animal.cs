namespace PrototypeExample
{
    abstract class Animal
    {
        public abstract void Speak();
        public abstract string Type { get; }
    }

    //class Dog : Animal
    //{
    //    public override void Speak()
    //    {
    //        Console.WriteLine("Woof");
    //    }
    //}

    //class Chicken : Animal
    //{
    //    public override void Speak()
    //    {
    //        Console.WriteLine("Chick");
    //    }
    //}

    //class Cow : Animal
    //{
    //    public override void Speak()
    //    {
    //        Console.WriteLine("Moo");
    //    }
    //}

    //class Sheep : Animal
    //{
    //    public override void Speak()
    //    {
    //        Console.WriteLine("Bah");
    //    }
    //}
}
