using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs
{
    class SelectionSort
    {
        public static void Selectionsort<T>(T[] list) where T : IComparable<T>
        {
            for (int k = 0; k < list.Length - 1; k++)
            {
                int minPos = k;
                for (int j = k + 1; j < list.Length; j++)
                    if (list[j].CompareTo(list[minPos]) < 0)
                        minPos = j;
                // Now swap the k'th and smallest items
                T tmp = list[k];
                list[k] = list[minPos];
                list[minPos] = tmp;
            }
        }
    }
}
