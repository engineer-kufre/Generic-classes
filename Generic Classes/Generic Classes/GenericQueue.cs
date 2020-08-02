using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Classes
{
    class GenericQueue<T>
    {
        GenericLinkedList<T> queue = new GenericLinkedList<T>();
        int Count = 0;
        public bool IsEmpty()
        {
            //returns a boolean
            return Count == 0;
        }
        public void Enqueue(T item)
        {
            //add items to the queue
            if (Count == 0)
            {
                queue.Add(item);
            }
            else
            {
                queue.Insert(item, 0);
            }
            Count++;
        }
        public T Dequeue()
        {
            //removes the last item from the queue
            LinkedListNode<T> dequeuedElem = queue.Last;
            queue.Remove();
            Count--;
            return dequeuedElem.Value;
        }
        public int Size()
        {
            //shows the number of items in the queue
            return Count;
        }
        public void Print()
        {
            Console.WriteLine("Print what?");
        }
    }
}
