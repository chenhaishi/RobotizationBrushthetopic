using DataSourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handle
{
    public interface IHandleBase<T>: IRepostitory<T> where T : class
    {
        

    }
}
