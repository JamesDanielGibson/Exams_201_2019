namespace ADTs
{
    using System;

    /// <summary>
    /// Defines the <see cref="Program" />
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/></param>
        internal static void Main(string[] args)
        {
            ObjectList ol = new ObjectList();
            IntegerList il = new IntegerList();
            IntegerVector iv = new IntegerVector();
            GenericList<int> gl = new GenericList<int>();

            for (int i = 0; i < 10; i++)
            {
                gl.Add(i);

            }
            Console.Write(gl.ToString());
            gl.Remove(2);
            Console.Write(gl.ToString());





            Console.Read();
        }

        /// <summary>
        /// The testStack
        /// </summary>
        public void testStack()
        {
            IStack<char> st = new ListStack<char>(); // Or ArrayStack
            Console.WriteLine("\nEnter text:\n ");
            char ch = (char)Console.Read();
            while (ch != '\n')
            {
                st.Push(ch);
                ch = (char)Console.Read();
            }
            Console.WriteLine(st.ToString());
            Console.Write("\nBackwards: \n");
            while (!st.IsEmpty())
                Console.Write(st.Pop());
            Console.WriteLine(st.ToString());
        }
    }
}
