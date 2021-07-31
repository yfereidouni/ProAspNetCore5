using CourseStore.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace CourseStore.Infra.Data.Sql
{
    public class CourseDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

    }
}
