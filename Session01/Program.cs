using Session01.BeginingEFCore5.DataAccess;
using Session01.BeginingEFCore5.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Session01.BeginingEFCore5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create
            //DataClass.WriteCourse();

            //Read
            DataClass.ReadAllCourse();

            //Update
            DataClass.UpdateCourse(1, "ASP.NET Core 5 and EF");

            Console.WriteLine("Press a key ...");
            Console.Read();
        }

        
    }
}
