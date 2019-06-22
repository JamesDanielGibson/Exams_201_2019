namespace ADTs
{
    using System;

    /// <summary>
    /// Defines the <see cref="ArrayQueue{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ArrayQueue<T> : IQueue<T>
    {
        /// <summary>
        /// Defines the data
        /// </summary>
        private T[] data;

        /// <summary>
        /// Defines the hd
        /// </summary>
        private int hd;

        /// <summary>
        /// Defines the tl
        /// </summary>
        private int tl;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayQueue{T}"/> class.
        /// </summary>
        /// <param name="initSize">The initSize<see cref="int"/></param>
        public ArrayQueue(int initSize)
        {
            data = new T[initSize];
            hd = tl = -1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayQueue{T}"/> class.
        /// </summary>
        public ArrayQueue() : this(100)
        {
        }

        /// <summary>
        /// The Add
        /// </summary>
        /// <param name="item">The item<see cref="T"/></param>
        public void Add(T item)
        {
            tl = (tl + 1);
            if (tl >= data.Length)
                tl = 0;
            if (tl == hd)
                throw new Exception("no space");
            data[tl] = item;
            if (hd == -1)
                hd = tl;
        }

        /// <summary>
        /// The Head
        /// </summary>
        /// <returns>The <see cref="T"/></returns>
        public T Head()
        {
            if (hd == -1)
                throw new Exception("queue is empty");
            return data[hd];
        }

        /// <summary>
        /// The IsEmpty
        /// </summary>
        /// <returns>The <see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return hd == -1;
        }

        /// <summary>
        /// The Remove
        /// </summary>
        /// <returns>The <see cref="T"/></returns>
        public T Remove()
        {
            if (hd == -1)
                throw new Exception("queue is empty");
            T tmpData = data[hd];
            if (hd == tl) // Was last element
                hd = tl = -1;
            else
            {
                hd = (hd + 1);
                if (hd >= data.Length)
                    hd = 0; // wraparound 
            }
            return tmpData;
        }
    }
}
