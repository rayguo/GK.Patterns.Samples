using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompositeExample.Composition;

namespace VisitorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            UseVisitor();
        }

        private static void UseVisitor()
        {
            Console.WriteLine("Before:");
            var root = Blog.RootCategory;
            PrintBlogComponents(root);

            VisitBlogComponents(root);

            Console.WriteLine("\nAfter:");
            PrintBlogComponents(root);
        }

        private static void VisitBlogComponents(BlogCategory root)
        {
            var visitor = new BlogEntryVisitor();
            root.Accept(visitor);
        }

        private static void PrintBlogComponents(BlogCategory root)
        {
            foreach (var component in root.FindAll())
            {
                Console.WriteLine(component);
            }
        }
    }
}
