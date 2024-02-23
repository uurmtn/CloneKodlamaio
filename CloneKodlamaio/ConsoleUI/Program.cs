using CloneKodlamaio.Business.Abstracts;
using CloneKodlamaio.Business.Concretes;
using CloneKodlamaio.DataAccess.Abstracts;
using CloneKodlamaio.DataAccess.Concretes;
using CloneKodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static ICourseService _courseService = new CourseManager(new CourseDal());
        static ICategoryService _categoryService = new CategoryManager(new CategoryDal());
        static IInstructorService _instructorService = new InstructorManager(new InstructorDal());

        static void Main(string[] args)
        {
            List<Course> courses = _courseService.GetList();
            List<Instructor> instructors = _instructorService.GetList();
            List<Category> categories = _categoryService.GetList();


            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine("----------Kursun----------\n" + "Adı: " + courses[i].CourseName + "\nAçıklaması: " + courses[i].CourseDescription + "\nFiyatı:" + courses[i].CoursePrice + " TL" + "\nEğitmen: " + courses[i].InstructorFirstName);
            }
            Console.WriteLine("/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\");

            foreach (var category in categories)
            {
                Console.WriteLine("Kategori Adı: " + category.CategoryName + "\nID: " + category.CategoryId);
            }
            Console.WriteLine("/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\");
            foreach (var instructor in instructors)
            {
                Console.WriteLine("Eğitmen Adı: " + instructor.InstructorFirstName + "\nEğitmen Soyadı: " + instructor.InstructorLastName + "\nID:" + instructor.InstructorId + "\n---------------------");
            }
            Console.WriteLine("/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\*/*\\");
           
            
            CategoryTest();
            Console.WriteLine("------------------------------");
            CourseTest();
            Console.WriteLine("------------------------------");
            InstructorTest();



        }

        private static void CategoryTest()
        {
            Category category1 = new Category();
            category1.CategoryId = 1;
            category1.CategoryName = "Test";
            CategoryManager category = new CategoryManager(new CategoryDal());
            category.Add(category1);
            category.Delete(category1);
            category.Update(category1);

        }

        private static void CourseTest()
        {
            Course course1 = new Course();
            course1.CategoryId = 1;
            course1.CourseName = "Test";
            course1.CategoryId = 2;
            course1.CourseDescription = "Test";
            course1.CoursePrice = 1;
            course1.InstructorFirstName = "Test";
            course1.InstructorId = 2;
            course1.Image = "Test";
            CourseManager courses = new CourseManager(new CourseDal());
            courses.Add(course1);
            courses.Delete(course1);
            courses.Update(course1);

        }

        private static void InstructorTest()
        {
            Instructor instructor1 = new Instructor();
            instructor1.InstructorId = 1;
            instructor1.InstructorFirstName = "Test";
            instructor1.InstructorLastName = "Test";
            InstructorManager instructor = new InstructorManager(new InstructorDal());
            instructor.Add(instructor1);
            instructor.Delete(instructor1);
            instructor.Update(instructor1);
        }


    }

}
