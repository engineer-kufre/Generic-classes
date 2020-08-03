using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generic_Classes
{
    public class GenericLinkedList<T> : ICollection<T>
    {
        public LinkedListNode<T> First { get; private set; }
        public LinkedListNode<T> Last { get; private set; }
        public int Count = 0;
        int ICollection<T>.Count => throw new NotImplementedException();

        bool ICollection<T>.IsReadOnly => throw new NotImplementedException();

        public int Add(T item)
        {
            //adds an item and returns the size
            LinkedListNode<T> newNode = new LinkedListNode<T>(item);
            
            if (First == null)
            {
                Last = newNode;

                First = Last;
            }
            else
            {
                Last.Next = newNode;
                newNode.Previous = Last;
                Last = newNode;
                Last.Next = null;
            }
            Count++;
            return Count;
        }

        void ICollection<T>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<T>.Contains(T item)
        {
            throw new NotImplementedException();
        }
        public bool Check(T item)
        {
            //checks if an item is present and returns a boolean
            LinkedListNode<T> current = First;

            while (current != null)
            {
                if(current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public dynamic Search(T item)
        {
            //searches for an item and returns it
            //returns -1 if item isn't found
            LinkedListNode <T> current = First;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    Console.WriteLine($"{item} is present in the LinkedList.");
                    return item;
                }
                current = current.Next;
            }
            Console.WriteLine($"{item} does not exist in the LinkedList.");
            return -1;
        }
        public int Index(T item)
        {
            //returns the index of an item
            LinkedListNode<T> current = First;
            int index = 0;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }
        public bool IsEmpty()
        {
            //returns true if linkedlist is empty and false if it isn't
            if (First == null)
            {
                return true;
            }
            return false;
        }
        public int Size()
        {
            //returns linkedlist<T> size
            return Count;
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            //removes the last list item
            Last = Last.Previous;
            if (Last != null)
            {
                Last.Next = null;
            }
            Count--;
        }
        public bool Remove(T item)
        {
            //removes the first occurrence of an item
            //returns true if item is found and removed
            //returns false otherwise
            if (First == null)
            {
                return false;
            }
            else
            {
                LinkedListNode<T> current = First;
                int index = 0;
                while (current != null)
                {
                    if (current.Value.Equals(item))
                    {
                        //if(current.Previous == null)
                        if (index == 0)
                        {
                            First = current.Next;
                            if (First != null)
                            {
                                First.Previous = null;
                            }
                        }
                        else
                        {
                            current.Previous.Next = current.Next;
                        }
                        //if(current.Next == null)
                        if (index == Count)
                        {
                            Last = current.Previous;
                            if (Last != null)
                            {
                                Last.Next = null;
                            }
                        }
                        else
                        {
                            current.Next.Previous = current.Previous;
                        }
                        Count--;
                        return true;
                    }
                    current = current.Next;
                    index++;
                }
                return false;
            }
        }
        public void Insert(T item, int position)
        {
            //adds an item at the specified position
            if (position > Count)
            {
                throw new IndexOutOfRangeException();
            }
            LinkedListNode<T> newNode = new LinkedListNode<T>(item);
            LinkedListNode<T> current = First;
            int index = 0;
            while (index <= position)
            {
                if (index == position)
                {
                    
                    if (position == 0)
                    {
                        First.Previous = newNode;
                        newNode.Next = First;
                        First = newNode;
                        newNode.Previous = null;
                    }
                    else
                    {
                        newNode.Next = current;
                        current.Previous.Next = newNode;
                        newNode.Previous = current.Previous;
                        current.Previous = newNode;
                    }
                    
                    Count++;
                }
                current = current.Next;
                index++;
            }
        }

        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }
    }
}
