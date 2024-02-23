using CloneKodlamaio.DataAccess.Abstracts;
using CloneKodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaio.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors = new List<Instructor> 
            {
                new Instructor {InstructorId=1,InstructorFirstName="Engin",InstructorLastName="Demirog"},
                new Instructor {InstructorId=2,InstructorFirstName="Halit Enes",InstructorLastName="Kalaycı"}
            };
        }
        public void Add(Instructor t)
        {
            Console.WriteLine("Eğitmen Eklendi.....");
            _instructors.Add(t);
        }

        public void Delete(Instructor t)
        {
            Console.WriteLine("Eğitmen Silindi....");
            _instructors.Remove(t);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor t)
        {
            Console.WriteLine("Eğitmen Güncellendi....");
            Instructor instructor = _instructors.SingleOrDefault(p => p.InstructorId == t.InstructorId);
            t.InstructorId = t.InstructorId;
            t.InstructorFirstName = t.InstructorFirstName;
            t.InstructorLastName= t.InstructorLastName;
        }
    }
}
