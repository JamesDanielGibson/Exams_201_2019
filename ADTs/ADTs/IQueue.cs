using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs
{
    interface IQueue<T>
    {
        void Add(T item);
        T Remove();
        T Head();
        bool IsEmpty();
    }
}
