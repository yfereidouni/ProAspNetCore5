using Microsoft.EntityFrameworkCore;
using System;

namespace CourseStore.Infra.Data.Sql
{
    public static class ContextFactory
    {
        public static CourseDbContext GetSqlContext()
        {
            var builder = new DbContextOptionsBuilder<CourseDbContext>();
            builder.UseSqlServer("Server =.,1433; Database = CourseStore; Integrated Security = True;")
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
                //.UseLazyLoadingProxies();
            return new CourseDbContext(builder.Options);
        } 
    }
}
