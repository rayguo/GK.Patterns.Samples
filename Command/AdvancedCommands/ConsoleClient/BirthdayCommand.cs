using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace ConsoleClient
{
    public class BirthdayCommand : ICommandWithUndo
    {
        private readonly Person _person;

        public BirthdayCommand(Person person)
        {
            _person = person;
        }

        public void Execute()
        {
            _person.Age++;
        }

        public void Undo()
        {
            _person.Age--;
        }
    }
}
