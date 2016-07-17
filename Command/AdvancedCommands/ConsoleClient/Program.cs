using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Invokers;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { Name = "John", Age = 30 };
            PrintPerson(person);

            //UseBasicInvoker(person);
            UseUndoRedoInvoker(person);
        }

        private static void UseUndoRedoInvoker(Person person)
        {
            var command = new BirthdayCommand(person);

            var invoker = new UndoRedoInvoker();

            int count = 3;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Press Enter to execute");
                Console.ReadLine();
                invoker.Execute(command);
                PrintPerson(person);
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Press Enter to undo");
                Console.ReadLine();
                invoker.Undo();
                PrintPerson(person);
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Press Enter to re-do");
                Console.ReadLine();
                invoker.Redo();
                PrintPerson(person);
            }
        }

        private static void UseBasicInvoker(Person person)
        {
            var command = new DelegateCommand(() =>
            {
                person.Age++;
                PrintPerson(person);
            });

            var invoker = new BasicInvoker();
            invoker.InvokeCommand(command);
        }

        private static void PrintPerson(Person person)
        {
            Console.WriteLine("{0} {1}", person.Name, person.Age);
        }
    }
}
