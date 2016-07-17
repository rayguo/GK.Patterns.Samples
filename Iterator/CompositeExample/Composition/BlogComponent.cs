using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeExample.Composition
{
    abstract partial class BlogComponent
    {
        // Blog entry only
        public virtual DateTime Date { get; set; }

        // Blog entry and category
        public abstract string Title { get; set; }
        public abstract IEnumerable<BlogComponent> Children { get; }

        // Traverse hierarchical structure
        public virtual IEnumerable<BlogComponent> FindAll()
        {
            // Return ourselves first
            yield return this;

            // Enumerate children
            foreach (BlogComponent cpt in Children)
            {
                // Recursively enumerate children
                foreach (BlogComponent child in cpt.FindAll())
                {
                    yield return child;
                }
            }
        }
    }
}
    