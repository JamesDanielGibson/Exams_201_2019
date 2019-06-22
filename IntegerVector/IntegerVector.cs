using System;
using System.Text;
public class IntegerVector
{
    public class IntgerVector
    {
        private int[] data;
        private int numElements;

        public IntegerVector(int initSize)
        {
            if (initSize <= 0)
            {
                throw new System.ArgumentException("Negative or zero value entered.");
            }
        }
    }//Constructor

    public IntegerVector():this(100)
    {
    }//constructor

    public void Add(int item)
    {//palce the new item at the end of an IntegerVector
        if(numElements + 1> data.Length)
        {
            throw new NoSpaceAvailableException("No Space");
        }
        data[numElement++] = item;
    }//add

    /// <summary>
    ///  if there are elements in the array it will shift every thing up and insert the item into the provided position.
    /// </summary>
    /// <param name="item"></param>
    /// <param name="position"></param>
    public void Add(int item ,int position)//overloaded version of the above code. if there are elements in the array it will shift every thing up and insert the item into the provided position.
    {
        if (numElements + 1 > data.Length)
            throw new NoSpaceAvailableException("no space available");
        if (postion < 0)
            throw new System.ArugumentException("position is negative");
        if (position >= numElements)//Add at the end
            data[numElements++] = item;
        else
        {
            
            for (int i = numElements; i >=position; i--)
            {
                data[i + 1] = data[k];//move elements up
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
    }//get

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
    }//Set


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
        if (index < 0 || index >= numElements)
            throw new IndexOutOfRangeException("index is out of range");
        for (int i = pos; i < numElements; i++)
        {
            data[i-1] = data[i ];
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
    }//Output

    /// <summary>
    /// Creates a String containg all the values of the data type.
    /// </summary>
    public void ToString()
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
    }// ToString

    /// <summary>
    /// returns the number of elements in the array.
    /// </summary>
    /// <returns></returns>
    public int Length()
    {
        return numElements;
    }
}
