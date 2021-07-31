using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Core.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Discount Discount { get; set; }
        public List<Tag> Tags { get; set; }
        public List<CourseTeacher> CourseTeachers { get; set; }
        public List<Comment> Comments { get; set; }
    }

}
