using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeExample.Iteration
{
    class BlogEntry
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public BlogEntry(string title, DateTime date)
        {
            Title = title;
            Date = date;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Title, 
                Date.ToShortDateString());
        }
    }
}
