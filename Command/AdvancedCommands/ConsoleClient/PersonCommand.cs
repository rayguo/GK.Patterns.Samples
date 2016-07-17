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
    public class PersonCommand : ICommandWithUndo
    {
        private readonly Person _person;

        public PersonCommand(Person person)
        {
            _person = person;
        }

        public override void Execute()
        {
            base.Execute();
        }

        public void Undo()
        {
            Person = _cachedPerson;
        }
    }
}
