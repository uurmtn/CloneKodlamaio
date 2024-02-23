using CloneKodlamaio.DataAccess.Abstracts;
using CloneKodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CloneKodlamaio.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course>
            {
                new Course{CourseId=1,CategoryId=1,CourseDescription="Backend",CourseName="C#",CoursePrice=0.00,Image="resim....."},
                new Course{CourseId=2,CategoryId=2,CourseDescription="Frontend",CourseName="Angular",CoursePrice=0.00,InstructorId=2,Image="resim....."},
                new Course{CourseId=3,CategoryId=1,CourseDescription="Backend",CourseName="Java",CoursePrice=0.00,Image="resim....."},
                new Course{CourseId=4,CategoryId=2,CourseDescription="Backend",CourseName="Python",CoursePrice=0.00,Image="resim "},
                new Course{CourseId=5,CategoryId=1,CourseDescription="Frontend",CourseName="JavaScript",CoursePrice=0.00,Image="resim "},

            };
        }
        public void Add(Course t)
        {
            Console.WriteLine("Kurs Eklendi...");
            _courses.Add(t);
        }

        public void Delete(Course t)
        {
            Console.WriteLine("Kurs Silindi...");
            _courses.Remove(t);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course t)
        {
            Console.WriteLine("Kurs Güncellendi...");
            Course _course = _courses.SingleOrDefault(p => p.CourseId == t.CourseId);
            t.CourseId = t.CourseId;
            t.CourseName = t.CourseName;
            t.CoursePrice = t.CoursePrice;
            t.CourseDescription = t.CourseDescription;
            t.Image = t.Image;
            t.CategoryId = t.CategoryId;
            t.InstructorId = t.InstructorId;
            t.InstructorFirstName = t.InstructorFirstName;

        }
    }
}
