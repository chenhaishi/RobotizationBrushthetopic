using Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handle
{
    public class TSTTHandle : HandleBase<TSTT>
    {
        public int add(TSTT t)
        {
            return this.Add(t);
        }
    }
}
