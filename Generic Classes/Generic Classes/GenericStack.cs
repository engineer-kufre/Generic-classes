using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Classes
{
    public class GenericStack<T>
    {
        GenericLinkedList<T> stack = new GenericLinkedList<T>();
        int Count = 0;

        public bool IsEmpty()
        {
            //returns a boolean
            return Count == 0;
        }
        public void Push(T item)
        {
            //add items to the stack
            stack.Add(item);
            Count++;
        }
        public T Pop()
        {
            //removes the last item from the stack
            LinkedListNode<T> poppedElem = stack.Last;
            stack.Remove();
            Count--;
            return poppedElem.Value;
        }
        public T Peek()
        {
            //returns the last item added
            if (Count > 0)
            {
                return stack.Last.Value;
            }
            else
            {
                return default;
            }
        }
        public int Size()
        {
            //shows the number of items in the stack
            return Count;
        }
        public void Print(T item)
        {
            Console.WriteLine(item);
        }
    }
}
