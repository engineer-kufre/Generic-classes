using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericLinkedList<int> myList = new GenericLinkedList<int>();
            myList.Add(200);
            myList.Add(300);
            myList.Add(400);
            myList.Add(500);
            Console.WriteLine(myList.Index(500));
            Console.WriteLine(myList.Size());
            myList.Remove(400);
            Console.WriteLine(myList.Check(300));
           Console.WriteLine(myList.Search(200));
           Console.WriteLine(myList.Search(400));
           Console.WriteLine(myList.IsEmpty());
           Console.WriteLine(myList.Size());
           myList.Insert(400, 2);
           Console.WriteLine(myList.Index(400));

            //Stack<string> myStack = new Stack<string>();
            //Console.WriteLine(myStack.Peek());
            //Console.WriteLine(myStack.Size());
            //myStack.Push("name");
            //myStack.Push("age");
            //myStack.Push("time");
            //Console.WriteLine(myStack.Peek());
            //Console.WriteLine(myStack.Size());
            //Console.WriteLine(myStack.IsEmpty());
            //var popped = myStack.Pop();
            //Console.WriteLine(popped);
            //Console.WriteLine(myStack.Peek());
            //Console.WriteLine(myStack.Size());
            //Console.WriteLine(myStack.IsEmpty());

            List<int> list = new List<int>();
            list.Add(2);
            Stack some = new Stack();
            list.Add(2);
        }
    }
}
