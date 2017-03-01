using AutomaticMigration.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutomaticMigration.Models
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // True if the database is created, false if it already existed.
            context.Database.Migrate();
            bool isCreated = context.Database.EnsureCreated();
            if (isCreated)
            {
                // Look for any students.
                if (context.Courses.Any())
                {
                    return;   // DB has been seeded
                }
                var courses = new Course[]
                {
                    new Course{Title="Chemistry"},
                    new Course{Title="Microeconomics"},
                    new Course{Title="Macroeconomics"},
                    new Course{Title="Calculus"},
                    new Course{Title="Trigonometry"},
                    new Course{Title="Composition"},
                    new Course{Title="Literature"}
                };
                foreach (Course c in courses)
                {
                    context.Courses.Add(c);
                }
                context.SaveChanges();
            }
        }
    }
}
