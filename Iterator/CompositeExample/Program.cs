using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iterate with external iteration
            //IterateBlog();

            // Iterate with iterator method
            //UseIteration();

            // Iterate with composition
            //UseComposition();

            // Iterate with composition and filtering
            //UseCompositionWithLinq();
        }

        private static void UseCompositionWithLinq()
        {
            Console.WriteLine("From Date:");
            DateTime fromDate = DateTime.Parse(Console.ReadLine());

            var query = from c in Composition.Blog.RootCategory.FindAll()
                        let e = c as Composition.BlogEntry
                        where e != null && e.Date >= fromDate
                        select e;

            foreach (var component in query)
            {
                Console.WriteLine(component);
            }
        }

        private static void UseComposition()
        {
            foreach (var component in Composition.Blog.RootCategory.FindAll())
            {
                if (component is Composition.BlogCategory)
                    Console.WriteLine();
                Console.WriteLine(component);
            }
        }

        private static void UseIteration()
        {
            foreach (var item in Iteration.Blog.RootCategory.FindAll())
            {
                Console.WriteLine(item);
            }
        }

        private static void IterateBlog()
        {
            var root = Iteration.Blog.RootCategory;
            Console.WriteLine(root.Title);
            IterateCategory(root);
        }

        // Problem: Can break if structure changes
        private static void IterateCategory(Iteration.BlogCategory root)
        {
            // Print entries
            foreach (var entry in root.Entries)
                Console.WriteLine(entry);

            // Print categories
            foreach (var category in root.Categories)
            {
                Console.WriteLine("\n{0}", category.Title);

                // Recursively print entries and categories
                IterateCategory(category);
            }
        }
    }
}
