using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateEnum
{
    class Book
    {
        public string Title { get; private set; }

        public Book(string title)
        {
            Title = title;
        }
    }
}
