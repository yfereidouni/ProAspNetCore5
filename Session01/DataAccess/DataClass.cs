using Microsoft.EntityFrameworkCore;
using Session01.BeginingEFCore5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01.BeginingEFCore5.DataAccess
{
    public class DataClass
    {
        public static void WriteCourse()
        {
            var course = new Course
            {
                Title = "ASP.NET Core 5",
                Price = 100,
                Tags = new List<Tag>
                {
                    new Tag
                    {
                        Name = ".NET"
                    },
                    new Tag
                    {
                        Name = "Programming"
                    }
                }
            };
            var ctx = new BeginingEfCore5Context();
            ctx.Add(course);
            ctx.SaveChanges();
        }

        public static void ReadAllCourse()
        {
            var ctx = new BeginingEfCore5Context();
            var coursesQuery = ctx.Courses.AsNoTracking().Include(c=>c.Tags);
            var coursesQueryText = ctx.Courses.AsNoTracking().Include(c => c.Tags).ToQueryString();
            var courses = coursesQuery.ToList();

            foreach (var course in courses)
            {
                //Console.WriteLine("".PadLeft(100, '-'));
                foreach (var item in course.Tags)
                {
                    Console.WriteLine($"{course.Id} | {course.Title} | {course.Price} | Tag:> {item.Name}");

                    //Console.WriteLine($"{item.Name}");
                }
            }
        }

        public static void UpdateCourse(int id, string title)
        {
            var ctx = new BeginingEfCore5Context();
            var course = ctx.Courses.Find(id);
            course.Title = title;
            ctx.SaveChanges();
        }
    }
}
