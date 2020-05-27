using Common;
using System.Collections.Generic;

namespace DataStructure
{
    public class DualLinkedListNode<T>
    {
        public T Value { get; private set; }

        public DualLinkedListNode<T> Prev { get; set; }
        public DualLinkedListNode<T> Next { get; set; }

        public DualLinkedListNode(T value)
        {
            Value = ArgumentValidation.ThrowIfNull(value, nameof(value));
            Prev = null;
            Next = null;
        }
    }
}
