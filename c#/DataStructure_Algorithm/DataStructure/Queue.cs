using System;

namespace DataStructure
{
    /// <summary>
    /// Queue interface
    /// </summary>
    /// <typeparam name="T">Queue Element</typeparam>
    public interface IQueue<T>
    {
        /// <summary>
        /// Push the item into the queue
        /// </summary>
        /// <param name="value"></param>
        void Enqueue(T value);

        /// <summary>
        /// Pop up the head of the queue
        /// </summary>
        /// <returns></returns>
        T Dequeue();

        /// <summary>
        /// Return the head of the queue without removing
        /// </summary>
        /// <returns></returns>
        T Peek();

        /// <summary>
        /// Represent whether queue is empty
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        /// Elements count in the queue
        /// </summary>
        int Count { get; }
    }

    /// <summary>
    /// Queue implementation based on Array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Queue<T> : IQueue<T>
    {
        private const int DEFAULT_CAPACITY = 4;

        private T[] _internal;
        private int _capaticy;
        private int _head;
        private int _tail;

        public Queue()
        {
            _capaticy = DEFAULT_CAPACITY;
            _internal = new T[DEFAULT_CAPACITY];
            _head = 0;
            _tail = -1;
        }

        public int Count { get; private set; }

        public T Dequeue()
        {
            T head = Peek();
            _head = (_head + 1) % _capaticy;
            Count--;
            return head;
        }

        public void Enqueue(T value)
        {
            int _available = _capaticy;

            if (Count < _available)
            {
                _tail = (_tail + 1) % _available;
            }
            else if(Count == _available)
            {
                _capaticy = _capaticy * 2;
                T[] copy_internal = new T[_capaticy];
                for (int i = 0; i < Count; i++)
                {

                    int idx = (_head + i) % _available;
                    copy_internal[i] = _internal[idx];
                }
                _internal = copy_internal;
                _head = 0;
                _tail = Count;
            }

            Count++;
            _internal[_tail] = value;
        }

        public bool IsEmpty() => Count == 0;

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Empty queue");
            }

            return _internal[_head];
        }
    }
}
