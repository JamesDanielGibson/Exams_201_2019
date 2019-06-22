using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntList
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerList il = new IntegerList();
            il.Add(5);
            il.Set(0, 0);
            il.Remove(1);
            il.Add(4);
            Console.Write(il.ToString());
            Console.Read();
        }
    }
}
