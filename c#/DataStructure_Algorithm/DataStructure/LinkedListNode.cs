using Common;

namespace DataStructure
{
    public class LinkedListNode<T>
    {
        public T Value { get; private set; }

        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value)
        {
            Value = ArgumentValidation.ThrowIfNull(value, nameof(value));
            Next = null;
        }
    }
}
