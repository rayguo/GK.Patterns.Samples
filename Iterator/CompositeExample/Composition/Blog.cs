using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeExample.Composition
{
    static class Blog
    {
        public static BlogCategory RootCategory
        {
            get
            {
                var category = new BlogCategory("Root",
                    new List<BlogComponent>
                    {
                        new BlogEntry("Entry1", DateTime.Today),
                        new BlogEntry("Entry2", DateTime.Today.AddDays(1)),
                        new BlogCategory("Category1",
                            new List<BlogComponent>
                                {
                                    new BlogEntry("Entry3", DateTime.Today.AddDays(2)) ,
                                    new BlogCategory("Category2",
                                    new List<BlogComponent>
                                        { new BlogEntry("Entry4", DateTime.Today.AddDays(3)) })
                                })
                    });
                return category;
            }
        }
    }
}
