namespace PrototypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var cow1 = new PrototypeAnimal("cow");
            cow1.Speak();
            var cow2 = cow1.Clone();
            cow2.Speak();
        }
    }
}
