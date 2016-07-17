using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeExample.Composition
{
    abstract class BlogComponentVisitor
    {
        public virtual void VisitCategory(BlogCategory category) { }
        public virtual void VisitEntry(BlogEntry entry) { }
    }
}
