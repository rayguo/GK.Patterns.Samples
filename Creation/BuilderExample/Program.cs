using System;
using System.Text;

namespace BuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.AppendLine("Hello");
            builder.AppendLine("World");
            var text = builder.ToString();
            Console.WriteLine(text);
        }
    }
}
