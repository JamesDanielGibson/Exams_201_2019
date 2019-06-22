using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs
{
    public class Tree<T>
    {
        private T data;
        private Tree<T> lt;
        private Tree<T> rt;

        public Tree(T value,Tree<T> left, Tree<T> right)
        {
            lt = left;
            rt = right;
            data = value;
        }

        public Tree(T value):this(value,null,null)
        {
        }

        public Tree<T> Left()
        {
            return lt;
        }

        public Tree<T> Right()
        {
            return rt;
        }

        public void AddLeft(Tree<T> left)
        {
            if (lt != null)
                throw new InvalidOperationException("Subtree already exists");
            lt = left;
        }
        
        public void AddRight(Tree<T> right)
        {
            if (rt != null)
                throw new InvalidOperationException("Subtree already Exists");
            rt = right;
        }

        public void ReplaceLeft(Tree<T> left)
        {
            if (lt == null)
                throw new InvalidOperationException("Subtree already Exists");
            lt = left;
        }

        public void ReplaceRight(Tree<T> right)
        {
            if (rt == null)
                throw new InvalidOperationException("Subtree already Exists");
            rt = right;
        }

        public T getData()
        {
            return data;
        }
    }
}
