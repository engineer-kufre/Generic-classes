using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Classes
{
    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode<T> Previous { get; set; }
        public T Value { get; set; }

        public LinkedListNode(T value)
        {
            Value = value;
        }

        public LinkedListNode(T value, LinkedListNode<T> previous, LinkedListNode<T> next)
        {
            Value = value;
            Previous = previous;
            Next = next;
        }
    }
}
