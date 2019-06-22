namespace ADTs
{
    using System;

    /// <summary>
    /// Defines the <see cref="MergeSort" />
    /// </summary>
    internal class MergeSort
    {
        /// <summary>
        /// The recursiveMS
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list<see cref="T[]"/></param>
        /// <param name="start">The start<see cref="int"/></param>
        /// <param name="end">The end<see cref="int"/></param>
        private static void recursiveMS<T>(T[] list, int start, int end) where T : IComparable<T>
        {
            if (start < end)
            {
                int midpoint = (start + end) / 2;
                recursiveMS(list, start, midpoint);
                recursiveMS(list, midpoint + 1, end);
                merge(list, start, midpoint, end);
            }
        }

        /// <summary>
        /// The merge
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list<see cref="T[]"/></param>
        /// <param name="first">The first<see cref="int"/></param>
        /// <param name="mid">The mid<see cref="int"/></param>
        /// <param name="last">The last<see cref="int"/></param>
        private static void merge<T>(T[] list, int first, int mid, int last) where T : IComparable<T>
        {
            T[] tmp = new T[(last - first) + 1];
            int i = first, j = mid + 1, k = 0;
            while (i <= mid && j <= last)
                if (list[i].CompareTo(list[j]) < 0)
                    tmp[k++] = list[i++];
                else
                    tmp[k++] = list[j++];
            while (i <= mid)
                tmp[k++] = list[i++];
            while (j <= last)
                tmp[k++] = list[j++];
            for (int l = first; l <= last; l++)
            {
                list[l] = tmp[k - first];
            }
        }
    }
}


