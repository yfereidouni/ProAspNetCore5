using Microsoft.EntityFrameworkCore;

namespace CourseStore.Infra.Data.Sql
{
    public static class ContextFactory
    {
        public static CourseDbContext GetSqlContext()
        {
            var builder = new DbContextOptionsBuilder<CourseDbContext>();
            builder.UseSqlServer("Server =.,1433; Database = CourseStore; Integrated Security = True;").UseLazyLoadingProxies();
            return new CourseDbContext(builder.Options);
        } 
    }
}
