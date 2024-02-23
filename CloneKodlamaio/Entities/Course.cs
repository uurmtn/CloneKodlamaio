using CloneKodlamaio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaio.Entities
{
    public class Course:IEntity
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CategoryId { get;  set; }
        public int InstructorId { get; set; }
        public string InstructorFirstName { get; set; }
        public string CourseDescription { get; set; }
        public double CoursePrice { get; set; }
        public string Image {  get; set; }

        public Instructor Instructor { get; set; }
        public Category Category { get; set; }
    }
}
