using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeExample.Iteration
{
    static class Blog
    {
        public static BlogCategory RootCategory
        {
            get
            {
                var category = new BlogCategory("Root",
                    new List<BlogEntry>
                    {
                        new BlogEntry("Entry1", DateTime.Today),
                        new BlogEntry("Entry2", DateTime.Today.AddDays(1)),
                    },
                    new List<BlogCategory>
                    {
                        new BlogCategory("Category1",
                            new List<BlogEntry>
                                { new BlogEntry("Entry3", DateTime.Today.AddDays(2)) },
                            new List<BlogCategory>
                            {
                                new BlogCategory("Category2",
                                    new List<BlogEntry>
                                        { new BlogEntry("Entry4", DateTime.Today.AddDays(3)) },
                                    new List<BlogCategory>()),
                            })
                    });
                 
                return category;
            }
        }
    }
}
