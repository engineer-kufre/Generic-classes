using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Classes
{
    public class GenericStack<T>
    {
        GenericLinkedList<T> stack = new GenericLinkedList<T>();
        int Count = 0; //count tracker for Stack items

        public bool IsEmpty() //checks that Stack is empty and returns a boolean
        {
            return Count == 0;
        }

        public void Push(T item) //add items to the stack tail
        {
            stack.Add(item);
            Count++;
        }

        public T Pop() //removes the last item from the stack and returns it
        {
            LinkedListNode<T> poppedElem = stack.Last;
            stack.Remove();
            Count--;
            return poppedElem.Value;
        }

        public T Peek() //returns the last item added or the default type value if the Stack is empty
        {
            if (Count > 0)
            {
                return stack.Last.Value;
            }
            else
            {
                return default;
            }
        }

        public int Size() //shows the number of items in the stack
        {
            return Count;
        }

        public void Print(T item) //custom method for printing to the console
        {
            Console.WriteLine(item);
        }
    }
}
