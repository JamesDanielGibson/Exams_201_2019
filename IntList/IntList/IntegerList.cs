namespace IntList
{
    using System;
    using System.Diagnostics;
    using System.Text;

    /// <summary>
    /// Defines the <see cref="IntegerList" />
    /// </summary>
    public class IntegerList
    {
        /// <summary>
        /// Defines the <see cref="ListNode" />
        /// </summary>
        private class ListNode
        {
            /// <summary>
            /// Defines the data
            /// </summary>
            public int data;

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
        /// Initializes a new instance of the <see cref="IntegerList"/> class.
        /// </summary>
        public IntegerList()
        {
            first = null;
            numElements = 0;
        }

        /// <summary>
        /// Adds a new element to the begining of the  List
        /// </summary>
        /// <param name="item"></param>
        //public void Add(int item)
        //{
        //    ListNode node = new ListNode();
        //    node.data = item;
        //    node.next = first;
        //    first = node;
        //    numElements++;
        //}//Add

        /// <summary>
        /// Adds a new element to the begining of the  List
        /// </summary>
        /// <param name="item"></param>
        public void Add(int item)
        {
            Add(item, numElements);
        }

        /// <summary>
        /// Adds a new element to the list at a given position.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="position"></param>
        public void Add(int item, int position)
        {
            if (position < 0)
            {
                throw new ArgumentException("Position is negative");
            }
            ListNode node = new ListNode();
            node.data = item;
            ListNode curr = first, prev = null;
            for (int i = 0; i < position && curr != null; i++)
            // find Position
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
        /// Get the value of the list element at a given position.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int Get(int index)
        {
            if (index < 0 || index > numElements)
            {
                throw new IndexOutOfRangeException("index is out of range");
            }
            ListNode curr = first;
            for (int i = 0; curr != null && i < index; i++)
            {
                curr = curr.next;
            }
            Debug.Assert(curr != null);
            return curr.data;
        }

        /// <summary>
        /// Set the value of a given index to a new value.
        /// </summary>
        /// <param name="item">The item<see cref="int"/></param>
        /// <param name="index">The index<see cref="int"/></param>
        public void Set(int item, int index)
        {
            if (index < 0 || index > numElements)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            ListNode curr = first;
            for (int i = 0; curr != null && i < index; i++)
            {
                curr = curr.next;
            }
            Debug.Assert(curr != null);
            curr.data = item;
        }

        /// <summary>
        /// Returns a string containing the values of the list.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder s = new StringBuilder("[");
            for (ListNode curr = first; curr != null; curr = curr.next)
            {
                s.Append("" + curr.data);
                if (curr.next != null)
                {
                    s.Append(", ");
                }
            }
            s.Append("]");
            return s.ToString();
        }

        /// <summary>
        /// Returns the position of a given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Position(int item)
        {
            ListNode curr = first;
            int i;
            for (i = 0; curr != null && curr.data != item; curr = curr.next) ;
            if (curr == null)
                return -1;
            else
                return i;
        }

        /// <summary>
        /// Remove the node at a given index.
        /// </summary>
        /// <param name="pos">The pos<see cref="int"/></param>
        public void Remove(int pos)
        {
            if (pos < 0 || pos > numElements)
            {
                throw new IndexOutOfRangeException("Index is out of range");
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
    }
}
