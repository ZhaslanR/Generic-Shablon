using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageApp
{
    public class Repasitory<T> : IRepasitory<T> where T:Entity
    {
        public void Add(T entity)
        {
            Storage.DoWork();
            //пройсходить запись
        }

        public void Delete(T entity)
        {
            Storage.DoWork();
            //пройсходит удаление
        }

        public Entity Get(T id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
