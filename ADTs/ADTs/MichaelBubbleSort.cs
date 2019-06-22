using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs
{
    public class MichaelBubbleSort<T> where T : IComparable<T>
    {
        public static void BubbleSort<T>(T[] list) where T : IComparable<T>
        {
            bool madeSwap = true;
            for (int pass = 0; pass < list.Length && madeSwap; pass++)
            {
                madeSwap = false;
                for (int i = 0; i < list.Length - pass-1; i++)
                {
                    if (list[i].CompareTo(list[i + 1]) > 0)
                    {
                        T temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        madeSwap = true;
                    }
                }
            }
        }
    }
}
