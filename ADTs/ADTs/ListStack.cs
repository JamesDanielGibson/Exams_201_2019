using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs
{
    class ListStack<T> : IStack<T>
    {
        private class StackNode
        {
            public T data;
            public StackNode next;
        }

        private StackNode topNode;

        public ListStack()
        {
            topNode = null;
        }

        public void Push(T item)
        {
            StackNode node = new StackNode();
            node.data = item;
            node.next = topNode;
            topNode = node;
        }

        public T Pop()
        {
            if(topNode==null)
            {
                throw new Exception("Empty Stack");
            }
            T tmpData = topNode.data;
            topNode = topNode.next;
            return tmpData;
        }

        public T Top()
        {
            if (topNode == null)
                throw new Exception("Stack is Empty");
            return topNode.data;
        }

        public bool IsEmpty()
        {
            return topNode == null;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder("[");
            for (StackNode curr = topNode; curr != null; curr = curr.next)
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
