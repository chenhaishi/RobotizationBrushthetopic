using DataSourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handle
{
    public abstract class HandleBase<T> : IHandleBase<T> where T : class
    {

        public IRepostitory<T> Dal = new Repostitory<T>();


        public int Add(T t)
        {
            return Dal.Add(t);
        }

        public List<T> List()
        {
            return Dal.List();
        }

        public int Remove(T t)
        {
            return Dal.Remove(t);
        }

        public int RemoveRange(List<T> t)
        {
            return Dal.RemoveRange(t);
        }

        public int SaveChanges()
        {
            return Dal.SaveChanges();
        }

        public int Update(T t)
        {
            return Dal.Update(t);
        }
    }
}
