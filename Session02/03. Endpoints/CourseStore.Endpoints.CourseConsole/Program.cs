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
            QueryRepository.EagerLoadingSample01();

            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
