using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeExample.Composition
{
    partial class BlogEntry : BlogComponent
    {
        public override string Title { get; set; }
        public override DateTime Date { get; set; }

        public BlogEntry(string title, DateTime date)
        {
            Title = title;
            Date = date;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Title, Date.ToShortDateString());
        }

        public override IEnumerable<BlogComponent> Children
        {
            get { yield break; }
        }
    }
}
