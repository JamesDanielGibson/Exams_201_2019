namespace ADTs
{
    /// <summary>
    /// Defines the <see cref="IStack{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStack<T>
    {
        /// <summary>
        /// The Push
        /// </summary>
        /// <param name="item">The item<see cref="T"/></param>
        void Push(T item);

        /// <summary>
        /// The Pop
        /// </summary>
        /// <returns>The <see cref="T"/></returns>
        T Pop();

        /// <summary>
        /// The Top
        /// </summary>
        /// <returns>The <see cref="T"/></returns>
        T Top();

        /// <summary>
        /// The IsEmpty
        /// </summary>
        /// <returns>The <see cref="bool"/></returns>
        bool IsEmpty();
    }
}
