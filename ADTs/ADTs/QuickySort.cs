namespace ADTs
{
    using System;

    /// <summary>
    /// Defines the <see cref="QuickySort" />
    /// </summary>
    internal class QuickySort
    {
        /// <summary>
        /// The partition
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst">The lst<see cref="T[]"/></param>
        /// <param name="start">The start<see cref="int"/></param>
        /// <param name="end">The end<see cref="int"/></param>
        /// <returns>The <see cref="int"/></returns>
        private static int partition<T>(T[] lst, int start, int end) where T : IComparable<T>
        {
            int lt = start, rt = end; T tmp; while (lt < rt)
            {   // Work from right end first
                while (lst[rt].CompareTo(lst[start]) > 0)
                    rt--;// Now work up from start
                while (lt < rt && lst[lt].CompareTo(lst[start]) <= 0)
                    lt++;// swap list[lt] and list[rt]...
            }
            // Exchange the partition element
            // with list[rt]
            tmp = lst[start];
            lst[start] = lst[rt];
            lst[rt] = tmp;
            return rt;
        }

        /// <summary>
        /// The recursiveQS
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list<see cref="T[]"/></param>
        /// <param name="start">The start<see cref="int"/></param>
        /// <param name="end">The end<see cref="int"/></param>
        private static void recursiveQS<T>(T[] list, int start, int end) where T : IComparable<T>
        {
            if (start < end)
            {
                int partPoint = partition(list, start, end);
                recursiveQS(list, start, partPoint - 1);
                recursiveQS(list, partPoint + 1, end);
            }
        }

        /// <summary>
        /// The QuickSort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list<see cref="T[]"/></param>
        public static void QuickSort<T>(T[] list) where T : IComparable<T>
        {
            recursiveQS(list, 0, list.Length - 1);
        }
    }
}
