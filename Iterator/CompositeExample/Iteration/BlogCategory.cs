using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeExample.Iteration
{
    class BlogCategory
    {
        public string Title { get; private set; }
        public IEnumerable<BlogCategory> Categories { get; private set; }
        public IEnumerable<BlogEntry> Entries { get; private set; }

        public BlogCategory(string title, 
            IEnumerable<BlogEntry> entries,
            IEnumerable<BlogCategory> categories)
        {
            Title = title;
            Entries = entries;
            Categories = categories;
        }

        // Traverse hierarchical structure
        public IEnumerable<object> FindAll()
        {
            // Enumerate entries
            foreach (var entry in Entries)
            {
                yield return entry;
            }

            // Enumerate categories
            foreach (var category in Categories)
            {
                yield return category;

                // Recursively enumerate categories
                foreach (var child in category.FindAll())
                {
                    yield return child;
                }
            }
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
