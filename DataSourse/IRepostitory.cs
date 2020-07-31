using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSourse
{
    public interface IRepostitory<T> where T:class
    {

        int Add(T t);

        int Update(T t);

        int Remove(T t);

        int RemoveRange(List<T> t);

        List<T> List();

        int SaveChanges();
    }
}
