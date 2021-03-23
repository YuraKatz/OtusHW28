using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHW28
{
    interface IMyCloneable2<T> where T : class
    {
        T CloneV2();
    }
}
