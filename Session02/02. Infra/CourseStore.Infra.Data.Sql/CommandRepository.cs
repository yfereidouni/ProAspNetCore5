using CourseStore.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Sql
{
    public static class CommandRepository
    {
        public static void CheckEntityState()
        {
            var ctx = ContextFactory.GetSqlContext();
            var teacher = new Teacher
            {
                FirstName = "Masoud",
                LastName = "Taheri"
            };
            ctx.Add(teacher);
            Console.WriteLine($"Techer state is: {ctx.Entry(teacher).State}");
            var course = ctx.Courses.FirstOrDefault();

            Console.WriteLine($"Course state before change is: {ctx.Entry(course).State}");

            course.Title = "Pro EF and ASP.NET Core";

            Console.WriteLine($"Course state after change is: {ctx.Entry(course).State}");

            ctx.Remove(course);

            Console.WriteLine($"Course state after remove is: {ctx.Entry(course).State}");

            var tag = new Tag
            {
                Title = "New Tag"
            };

            Console.WriteLine($"Tag state : {ctx.Entry(tag).State}");
        }

        public static void ChangeTrackerState()
        {
            var ctx = ContextFactory.GetSqlContext();

            var teacher = new Teacher
            {
                FirstName = "Masoud",
                LastName = "Taheri"
            };

            ctx.Add(teacher);

            var course = ctx.Courses.FirstOrDefault();

            //ctx.Entry(course).Property(c => c.Title).CurrentValue = "Pro EF and ASP.NET Core";
            course.Title = "Pro EF and ASP.NET Core";

            //ctx.ChangeTracker.DetectChanges();

            Console.WriteLine(ctx.ChangeTracker.DebugView.LongView);

            //ctx.Remove(course);

            var tag = new Tag
            {
                Title = "New Tag"
            };

        }

        public static void CreateCourse(string title, string description, int price)
        {
            var course = new Course
            {
                Title = title,
                Description = description,
                Price = price
            };
            var ctx = ContextFactory.GetSqlContext();

            //ctx.Add(course); //when we use generics and dont know the type of object
            ctx.Courses.Add(course); //when we know which type would be add
            ctx.SaveChanges();
        }

        public static void CreateCourseWithDiscount(string title, string description, int price, int discountPrice, string discountTitle)
        {
            var course = new Course
            {
                Title = title,
                Description = description,
                Price = price,
                Discount = new Discount
                {
                    Name = discountTitle,
                    NewPrice = discountPrice
                }
            };

            var ctx = ContextFactory.GetSqlContext();
            //ctx.Add(course); //when we use generics and dont know the type of object
            ctx.Courses.Add(course); //when we know which type would be add
            Console.WriteLine(ctx.ChangeTracker.DebugView.LongView);
            ctx.SaveChanges();
            Console.WriteLine(ctx.ChangeTracker.DebugView.LongView);

        }
    }
}
