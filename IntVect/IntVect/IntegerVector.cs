namespace IntVect
{
    using System;
    using System.Text;

    /// <summary>
    /// Defines the <see cref="IntegerVector" />
    /// </summary>
    public class IntegerVector
    {
        /// <summary>
        /// Defines the data
        /// </summary>
        private int[] data;

        /// <summary>
        /// Defines the numElements
        /// </summary>
        private int numElements;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerVector"/> class.
        /// </summary>
        /// <param name="initSize"></param>
        public IntegerVector(int initSize)
        {
            if (initSize <= 0)
            {
                throw new System.ArgumentException("Negative or zero value entered.");
            }
            numElements = 0;
            data = new int[initSize];
        }

        //}//Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerVector"/> class.
        /// </summary>
        public IntegerVector() : this(100)
        {
        }

        /// <summary>
        /// Adds an item to array.
        /// </summary>
        /// <param name="item"></param>
        public void Add(int item)
        {
            if (numElements + 1 > data.Length)
            {
                //throw new NoSpaceAvailableException("No Space");
                throw new IndexOutOfRangeException("out of limits of array");
            }
            data[numElements++] = item;
        }

        /// <summary>
        /// if there are elements in the array it will shift every thing up and insert the item into the provided position.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="position"></param>
        public void Add(int item, int position)//overloaded version of the above code. if there are elements in the array it will shift every thing up and insert the item into the provided position.
        {
            if (numElements + 1 > data.Length)
                //throw new NoSpaceAvailableException("No Space");
                throw new IndexOutOfRangeException("out of limits of array");
            if (position < 0)
                //throw new NoSpaceAvailableException("No Space");
                throw new IndexOutOfRangeException("out of limits of array");
            if (position >= numElements)//Add at the end
                data[numElements++] = item;
            else
            {

                for (int i = numElements; i >= position; i--)
                {
                    data[i + 1] = data[i];//move elements up
                }
                data[position] = item;
                numElements++;
            }
        }

        /// <summary>
        /// Returns the value at a given index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int Get(int index)
        {
            if (index < 0 || index >= numElements)
                throw new IndexOutOfRangeException("index is out of range");
            return data[index];
        }

        /// <summary>
        /// Sets the value of a given index to a given value.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="Item"></param>
        public void Set(int index, int Item)
        {
            if (index < 0 || index >= numElements)
                throw new IndexOutOfRangeException("index is out of range");
            data[index] = Item;
        }

        /// <summary>
        /// Searches for a given item in the array and returns tha position of the item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Position(int item)
        {
            int i;
            for (i = 0; i < numElements; i++)
            {
                if (data[i] == item)
                    break;
            }
            if (i >= numElements)
                return -1;
            return i;
        }

        /// <summary>
        /// Removes an Item at a given position.
        /// </summary>
        /// <param name="pos"></param>
        public void Remove(int pos)
        {
            if (pos < 0 || pos >= numElements)
                throw new IndexOutOfRangeException("index is out of range");
            for (int i = pos; i < numElements; i++)
            {
                data[i - 1] = data[i];
            }
            numElements--;
        }

        /// <summary>
        /// Outputs the contents of the array.
        /// </summary>
        public void Output()
        {
            for (int i = 0; i < numElements; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Creates a String containg all the values of the data type.
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public override string ToString()
        {
            StringBuilder s = new StringBuilder("[");
            for (int i = 0; i < numElements; i++)
            {
                s.Append("" + data[i]);
                if (i < numElements - 1)
                    s.Append(", ");
            }
            s.Append("]");
            return s.ToString();
        }

        /// <summary>
        /// returns the number of elements in the array.
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return numElements;
        }
    }
}
