using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Interfaces
{
    interface IGenericDAO <T>
    {

        public bool Add(T entity);
        public bool Update(T entity);
        public bool Delete(T entity);
        public List<T> GetAll();
        public T GetById(int id);
    }
}
