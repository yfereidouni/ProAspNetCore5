﻿using System.Collections.Generic;

namespace Session01.BeginingEFCore5.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
