using CloneKodlamaio.Business.Abstracts;
using CloneKodlamaio.DataAccess.Abstracts;
using CloneKodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaio.Business.Concretes
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Course t)
        {
            _courseDal.Add(t);
        }

        public void Delete(Course t)
        {
            _courseDal.Delete(t);
        }


        public List<Course> GetList()
        {
            return _courseDal.GetAll();
        }

        public void Update(Course t)
        {
            _courseDal.Update(t);
        }
    }
}
