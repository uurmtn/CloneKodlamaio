using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaio.Core
{
    public interface IBaseDal<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        void Add(T t);
        void Update(T t);
        void Delete(T t);
    }
}
