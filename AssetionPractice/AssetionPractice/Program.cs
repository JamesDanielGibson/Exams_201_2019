using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace AssetionPractice
{
    class Program
    {
        /// <summary>
        /// this method divides a nmber by another
        /// </summary>
        /// <param name="i1"></param>
        /// <param name="i2"></param>
        /// <returns></returns>
        static int Devide(int i1,int i2)
        {
            Debug.Assert(i2 != 0, "devide by 0 error");
            return i1 / i2;
        }
        static void Main(string[] args)
        {
            Devide(1, 0);
        }
    }
}
