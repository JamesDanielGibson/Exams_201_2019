namespace ADTs
{
    using System;
    using System.Diagnostics;
    using System.Text;

    /// <summary>
    /// Defines the <see cref="GenericList{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericList<T>
    {
        /// <summary>
        /// Defines the <see cref="ListNode" />
        /// </summary>
        private class ListNode
        {
            /// <summary>
            /// Defines the data
            /// </summary>
            public T data;

            /// <summary>
            /// Defines the next
            /// </summary>
            public ListNode next;
        }

        /// <summary>
        /// Defines the first
        /// </summary>
        private ListNode first;

        /// <summary>
        /// Defines the numElements
        /// </summary>
        private int numElements;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericList{T}"/> class.
        /// </summary>
        public GenericList()
        {
            first = null;
            numElements = 0;
        }

        /// <summary>
        /// Adds a given element to a given location in the list.
        /// </summary>
        /// <param name="item">The item<see cref="T"/></param>
        /// <param name="Pos">The Pos<see cref="int"/></param>
        public void Add(T item, int Pos)
        {
            if (Pos < 0)
            {
                throw new ArgumentException("position is negative");
            }
            ListNode node = new ListNode();
            node.data = item;
            ListNode curr = first, prev = null;

            for (int i = 0; i < Pos && curr != null; i++)
            {
                prev = curr;
                curr = curr.next;
            }
            node.next = curr;
            if (prev != null)
            {
                prev.next = node;
            }
            else
            {
                first = node;
            }
            numElements++;
        }

        /// <summary>
        /// Adds a given element to the end of the list.
        /// </summary>
        /// <param name="item">The item<see cref="T"/></param>
        public void Add(T item)
        {
            Add(item, numElements);
        }

        /// <summary>
        /// Removes an element at a given index from the list.
        /// </summary>
        /// <param name="pos">The pos<see cref="int"/></param>
        public void Remove(int pos)
        {
            if (pos < 0 || pos >= numElements)
            {
                throw new IndexOutOfRangeException("Index was out of range");
            }

            ListNode curr = first, prev = null;
            for (int i = 0; curr != null && i < pos; i++)
            {
                prev = curr;
                curr = curr.next;
            }
            Debug.Assert(curr != null);
            if (prev != null)
                prev.next = curr.next;
            else
                first = curr.next;
            numElements--;
        }

        /// <summary>
        /// Returns the length of the list.
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        public int Length()
        {
            return numElements;
        }

        /// <summary>
        /// Returns an element at a given index.
        /// </summary>
        /// <param name="index">The index<see cref="int"/></param>
        /// <returns>The <see cref="T"/></returns>
        public T get(int index)
        {
            if (index < 0 || index >= numElements)
                throw new IndexOutOfRangeException("index is out of range");
            ListNode curr = first;
            for (int i = 0; curr != null && i < index; i++)
            {
                curr = curr.next;
            }
            Debug.Assert(curr != null);
            return curr.data;
        }

        /// <summary>
        /// Sets the value of an element to a new value, at a given index.
        /// </summary>
        /// <param name="item">The item<see cref="T"/></param>
        /// <param name="index">The index<see cref="int"/></param>
        public void Set(T item, int index)
        {
            if (index < 0 || index >= numElements)
                throw new IndexOutOfRangeException("index is out of range");
            ListNode curr = first;
            for (int i = 0; curr != null && i < index; i++)
            {
                curr = curr.next;
            }
            Debug.Assert(curr != null);
            curr.data = item;
        }

        /// <summary>
        /// Searches the list for the index of a given item.
        /// </summary>
        /// <param name="item">The item<see cref="T"/></param>
        /// <returns>The <see cref="int"/></returns>
        public int Position(T item)
        {
            ListNode curr = first;
            int i;
            for (i = 0; curr != null && !curr.Equals(item); i++, curr = curr.next) ;
            if (curr == null)
                return -1;
            else
                return i;
        }

        /// <summary>
        /// Converts the list to a string format.
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public override string ToString()
        {
            StringBuilder s = new StringBuilder("[");
            for (ListNode curr = first; curr != null; curr = curr.next)
            {
                s.Append(curr.data.ToString());
                if (curr != null)
                {
                    s.Append(", ");
                }
            }
            s.Append("]");
            return s.ToString();
        }
    }
}
