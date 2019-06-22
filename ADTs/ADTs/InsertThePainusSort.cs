namespace ADTs
{
    using System;

    /// <summary>
    /// Defines the <see cref="InsertThePainusSort" />
    /// </summary>
    internal class InsertThePainusSort
    {
        /// <summary>
        /// The InsertionSort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list<see cref="T[]"/></param>
        public static void InsertionSort<T>(T[] list) where T : IComparable<T>
        {
            for (int k = list.Length - 2; k >= 0; k--)
            {
                T tmp = list[k];
                int j = k + 1;
                while (j < list.Length && tmp.CompareTo(list[j]) > 0)
                {
                    list[j - 1] = list[j];
                    j++;
                }
                list[j - 1] = tmp;
            }
        }
    }
}
