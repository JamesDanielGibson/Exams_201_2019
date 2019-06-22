namespace Recusion
{
    using System;

    /// <summary>
    /// Defines the <see cref="Program" />
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The factorial
        /// </summary>
        /// <param name="f">The f<see cref="int"/></param>
        /// <returns>The <see cref="int"/></returns>
        internal static int factorial(int f)
        {
            if (f == 0)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(f);
                return f * factorial(f - 1);
            }
        }

        /// <summary>
        /// The WriteWordBackwards
        /// </summary>
        internal static void WriteWordBackwards()
        {
            char ch;
            ch = (char)Console.Read();
            if (ch != '\n')
            {
                WriteWordBackwards();
            }
            Console.Write(ch);
        }

        /// <summary>
        /// The Fib
        /// </summary>
        /// <param name="n">The n<see cref="int"/></param>
        /// <returns>The <see cref="int"/></returns>
        public static int Fib(int n)
        {
            if (n <=2)
                return 1;
            else
                return Fib(n - 1) + Fib(n - 2);
        }

        public static int fac(int n)
        {
            if (n < 1)
                return 1;
            else
                return n * fac(n - 1);
        }

        /// <summary>
        /// The Main
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/></param>
        public static void Main(string[] args)
        {
            //Console.Write(factorial(4));
            //WriteWordBackwards();
            Console.Write(fac(5));
            Console.Read();
        }
    }
}
