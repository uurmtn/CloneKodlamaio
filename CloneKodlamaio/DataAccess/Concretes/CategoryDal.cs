using CloneKodlamaio.DataAccess.Abstracts;
using CloneKodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaio.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>
            {
                new Category {CategoryId=1,CategoryName="Back-End"},
                new Category {CategoryId=2,CategoryName="Front-End"}
            };

        }
        public void Add(Category t)
        {
            Console.WriteLine("Kategori Eklendi...");
            _categories.Add(t);
        }

        public void Delete(Category t)
        {
            Console.WriteLine("Kategori Silindi...");
            _categories.Remove(t);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category t)
        {
            Console.WriteLine("Kategori Güncellendi...");
            Category _category = _categories.SingleOrDefault(p => p.CategoryId == t.CategoryId);
            t.CategoryId = t.CategoryId;
            t.CategoryName = t.CategoryName;

        }
    }
}
