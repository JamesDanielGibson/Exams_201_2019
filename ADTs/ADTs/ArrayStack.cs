namespace ADTs
{
    using System;
    using System.Text;

    /// <summary>
    /// Defines the <see cref="ArrayStack{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ArrayStack<T> : IStack<T>
    {
        /// <summary>
        /// Defines the data
        /// </summary>
        private T[] data;

        /// <summary>
        /// Defines the topIndex
        /// </summary>
        private int topIndex;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStack{T}"/> class.
        /// </summary>
        /// <param name="initSize">The initSize<see cref="int"/></param>
        public ArrayStack(int initSize)
        {
            data = new T[initSize];
            topIndex = -1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStack{T}"/> class.
        /// </summary>
        public ArrayStack() : this(100)
        {
        }

        /// <summary>
        /// The Push
        /// </summary>
        /// <param name="item">The item<see cref="T"/></param>
        public void Push(T item)
        {
            if (topIndex >= data.Length - 1)
            {
                throw new Exception("no Space");

            }
            data[++topIndex] = item;
        }

        /// <summary>
        /// The Pop
        /// </summary>
        /// <returns>The <see cref="T"/></returns>
        public T Pop()
        {
            if (topIndex < 0)
            {
                throw new Exception("stack is empty");
            }
            return data[topIndex];
        }

        /// <summary>
        /// The Top
        /// </summary>
        /// <returns>The <see cref="T"/></returns>
        public T Top()
        {
            if (topIndex < 0)
            {
                throw new Exception("List is empty");
            }
            return data[topIndex];
        }

        /// <summary>
        /// The IsEmpty
        /// </summary>
        /// <returns>The <see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return topIndex < 0;
        }

        /// <summary>
        /// The ToString
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public override string ToString()
        {
            StringBuilder s = new StringBuilder("[");
            for (int i = 0; i < data.Length; i++)
            {
                s.Append("" + data[i]);
                if (i < data.Length - 1)
                    s.Append(", ");
            }
            s.Append("]");
            return s.ToString();
        }
    }
}
