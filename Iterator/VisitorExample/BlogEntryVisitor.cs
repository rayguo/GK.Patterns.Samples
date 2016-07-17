using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeExample.Composition
{
    class BlogEntryVisitor : BlogComponentVisitor
    {
        public override void VisitEntry(BlogEntry entry)
        {
            entry.Date = entry.Date.AddDays(1);
        }
    }
}
