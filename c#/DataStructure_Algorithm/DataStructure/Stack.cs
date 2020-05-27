using System;

namespace DataStructure
{
    /// <summary>
    /// Stack Representation, LIFO
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStack<T>
    {
        /// <summary>
        /// Pop up item from top
        /// </summary>
        /// <returns></returns>
        T Pop();

        /// <summary>
        /// Return the item from top without removing
        /// </summary>
        /// <returns></returns>
        T Peek();

        /// <summary>
        /// Push item at the top
        /// </summary>
        void Push(T value);

        /// <summary>
        /// Identify whether stack is empty
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        /// Elements count in current stack
        /// </summary>
        int Count { get; }

    }

    public class Stack<T> : IStack<T>
    {
        private const int DEFAULT_CAPACITY = 4;

        private int _capacity;
        private int _top;

        private T[] _internal;

        public Stack(int capacity = 0)
        {
            _capacity = capacity == 0 ? DEFAULT_CAPACITY : capacity;
            _internal = new T[_capacity];
            _top = -1;
        }

        public int Count => _top + 1;

        public bool IsEmpty() => Count == 0;

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Empty Stack");
            }
            return _internal[_top];
        }

        public T Pop()
        {
            T top_valu = Peek();
            _top--;
            return top_valu;
        }

        public void Push(T value)
        {
            if(Count == _capacity)
            {
                _capacity = _capacity * 2;
                // increase teh capacity, copy into new internal list
                T[] copy_internal = new T[_capacity];
                for (int i = 0; i < Count; i++)
                {
                    copy_internal[i] = _internal[i];
                }
                _internal = copy_internal;
            }
            _top++;
            _internal[_top] = value;
        }
    }
}
