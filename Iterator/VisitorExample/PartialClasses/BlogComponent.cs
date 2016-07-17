using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeExample.Composition
{
    partial class BlogComponent
    {
        public abstract void Accept(BlogComponentVisitor visitor);
    }
}
