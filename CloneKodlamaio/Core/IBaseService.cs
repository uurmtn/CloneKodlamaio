using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneKodlamaio.Core
{
    public interface IBaseService<T> where T : class, IEntity, new()
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetList();

    }

}
