using Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> Root { get; private set; }

        public LinkedList(IList<T> list)
        {
            ArgumentValidation.ThrowIfNull(list, nameof(list));
            if (list.Count > 0)
            {
                LinkedListNode<T> p = null;
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == 0)
                    {
                        p = Root = new LinkedListNode<T>(list[i]);
                    }
                    else
                    {
                        p.Next = new LinkedListNode<T>(list[i]);
                        p = p.Next;
                    }
                }
            }
        }

        public LinkedList(params T[] list)
            : this(list.ToList())
        {
        }

        public void Print()
        {
            System.Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            var p = Root;
            StringBuilder repr = new StringBuilder();
            while (p != null)
            {
                string separate = p.Next == null ? "" : "=>";
                repr.Append($"{p.Value} {separate} ");
                p = p.Next;
            }
            repr.AppendLine();
            return repr.ToString();
        }
    }
}
