using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeExample.Composition
{
    partial class BlogEntry
    {
        public override void Accept(BlogComponentVisitor visitor)
        {
            visitor.VisitEntry(this);
        }
    }
}
