using CourseStore.Core.Domain;
using CourseStore.Infra.Data.Sql;
using System;
using System.Collections.Generic;

namespace CourseStore.Endpoints.CourseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandRepository.CreateCourseWithDiscount("Microservice 100", "Dicroservice Desc 100", 2100, 1550, "Norooz");

            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
