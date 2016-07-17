using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeExample.Composition
{
    partial class BlogCategory
    {
        public override void Accept(BlogComponentVisitor visitor)
        {
            visitor.VisitCategory(this);
            foreach (var child in Children)
            {
                // Call accept recursively
                child.Accept(visitor);
            }
        }
    }
}
