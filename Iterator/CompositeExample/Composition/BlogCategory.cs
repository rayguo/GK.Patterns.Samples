using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeExample.Composition
{
    partial class BlogCategory : BlogComponent
    {
        private IEnumerable<BlogComponent> _children;

        public BlogCategory(string title,
            IEnumerable<BlogComponent> children)
        {
            Title = title;
            _children = children;
        }

        public override string Title { get; set; }

        public override IEnumerable<BlogComponent> Children
        {
            get { return _children; }
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
