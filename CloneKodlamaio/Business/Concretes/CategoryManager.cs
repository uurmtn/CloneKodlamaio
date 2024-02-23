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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category t)
        {
            _categoryDal.Add(t);
        }

        public void Delete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetAll();
        }

        public void Update(Category t)
        {
           _categoryDal.Update(t);
        }
    }
}
