using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inApp = true;
            while (inApp == true)
            {
                inApp = RunApp(inApp);
            }
        }

        private static bool RunApp(bool inApp)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine();
            Console.WriteLine("What data struture would you like to test?: ");
            Console.WriteLine("1. LinkedList");
            Console.WriteLine("2. Stack");
            Console.WriteLine("3. Queue");
            Console.WriteLine();
            Console.Write("Please enter your data structure selection here. Or to exit the app, enter 0: ");
            string choice = Console.ReadLine();
            Console.WriteLine();
            if (choice == "1")
            {
                LinkedList();
            }
            if (choice == "2")
            {
                StackMethod();
            }
            if (choice == "3")
            {
                QueueMethod();
            }
            if (choice == "0")
            {
                inApp = false;
            }

            return inApp;
        }

        private static void QueueMethod()
        {
            bool inQueueClass = true;
            while (inQueueClass == true)
            {
                Console.WriteLine("Welcome to the Queue class!");
                Console.WriteLine();
                GenericQueue<string> myQueue = new GenericQueue<string>();
                Console.Write("Your Queue is empty. Enter the value of the first item to begin: ");
                string entry = Console.ReadLine();
                myQueue.Enqueue(entry);
                Console.WriteLine();
                myQueue.Print("Item added!");
                bool inQueue = true;
                while (inQueue == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("The operations below are available in the Queue class: ");
                    Console.WriteLine("1. Enqueue (This adds an item)");
                    Console.WriteLine("2. Dequeue (This removes an item)");
                    Console.WriteLine("3. IsEmpty (This checks if the Queue is empty)");
                    Console.WriteLine("4. Size (This shows the number of items in the Queue)");
                    Console.WriteLine("5. Exit Queue class menu");
                    Console.WriteLine();
                    Console.Write("Please select an operation: ");
                    string selection = Console.ReadLine();

                    if (selection == "1")
                    {
                        Console.Write("Please enter a value to enqueue: ");
                        entry = Console.ReadLine();
                        myQueue.Enqueue(entry);
                        Console.WriteLine();
                        myQueue.Print("Item added!");
                    }
                    else if (selection == "2")
                    {
                        string dequeued = myQueue.Dequeue();
                        Console.WriteLine();
                        myQueue.Print($"{dequeued} was removed from the Queue!");
                    }
                    else if (selection == "3")
                    {
                        bool isEmpty = myQueue.IsEmpty();
                        if (isEmpty == true)
                        {
                            myQueue.Print("The Queue is empty.");
                        }
                        else
                        {
                            myQueue.Print("The Queue is not empty.");
                        }
                    }
                    else if (selection == "4")
                    {
                        int queueSize = myQueue.Size();
                        myQueue.Print($"There are {queueSize} items currently present in the Queue.");
                    }
                    else if (selection == "5")
                    {
                        inQueue = false;
                    }
                    else
                    {
                        myQueue.Print("Wrong selection. Try again.");
                    }
                }
                Console.WriteLine();
                Console.Write("To continue into the Queue class menu, enter YES. To exit the Queue class, enter NO: ");
                string inClass = Console.ReadLine().ToUpper();
                if (inClass != "YES")
                {
                    inQueueClass = false;
                }
            }
        }

        private static void StackMethod()
        {
            bool inStackClass = true;
            while (inStackClass == true)
            {
                Console.WriteLine("Welcome to the Stack class!");
                Console.WriteLine();
                GenericStack<string> myStack = new GenericStack<string>();
                Console.Write("Your Stack is empty. Enter the value of the first item to begin: ");
                string entry = Console.ReadLine();
                myStack.Push(entry);
                Console.WriteLine();
                myStack.Print("Item added!");
                bool inStack = true;
                while (inStack == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("The operations below are available in the Stack class: ");
                    Console.WriteLine("1. Push (This adds an item)");
                    Console.WriteLine("2. Pop (This removes an item)");
                    Console.WriteLine("3. Peek (This returns the last item added)");
                    Console.WriteLine("4. IsEmpty (This checks if the Stack is empty)");
                    Console.WriteLine("5. Size (This shows the number of items in the Stack)");
                    Console.WriteLine("6. Exit Stack class menu");
                    Console.WriteLine();
                    Console.Write("Please select an operation: ");
                    string selection = Console.ReadLine();

                    if (selection == "1")
                    {
                        Console.Write("Please enter a value to add: ");
                        entry = Console.ReadLine();
                        myStack.Push(entry);
                        Console.WriteLine();
                        myStack.Print("Item added!");
                    }
                    else if (selection == "2")
                    {
                        string popped = myStack.Pop();
                        Console.WriteLine();
                        myStack.Print($"{popped} was removed from the stack!");
                    }
                    else if (selection == "3")
                    {
                        string peeked = myStack.Peek();
                        Console.WriteLine();
                        myStack.Print($"{peeked} is currently the last item in the stack!");
                    }
                    else if (selection == "4")
                    {
                        bool isEmpty = myStack.IsEmpty();
                        if (isEmpty == true)
                        {
                            myStack.Print("The Stack is empty.");
                        }
                        else
                        {
                            myStack.Print("The Stack is not empty.");
                        }
                    }
                    else if (selection == "5")
                    {
                        int stackSize = myStack.Size();
                        myStack.Print($"There are {stackSize} items currently present in the Stack.");
                    }
                    else if (selection == "6")
                    {
                        inStack = false;
                    }
                    else
                    {
                        myStack.Print("Wrong selection. Try again.");
                    }
                }
                Console.WriteLine();
                Console.Write("To continue into the Stack class menu, enter YES. To exit the Stack class, enter NO: ");
                string inClass = Console.ReadLine().ToUpper();
                if (inClass != "YES")
                {
                    inStackClass = false;
                }
            }
        }

        private static void LinkedList()
        {
            bool inLinkedListClass = true;
            while (inLinkedListClass == true)
            {
                Console.WriteLine("Welcome to the LinkedList class!");
                Console.WriteLine();
                GenericLinkedList<string> myList = new GenericLinkedList<string>();
                Console.Write("Your LinkedList is empty. Enter the value of the first item to begin: ");
                string entry = Console.ReadLine();
                myList.Add(entry);
                Console.WriteLine();
                Console.WriteLine("Item added!");
                //Console.WriteLine(");
                bool inLinkedList = true;
                while (inLinkedList == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("The operations below are available in the LinkedList class: ");
                    Console.WriteLine("1. Add (This adds an item)");
                    Console.WriteLine("2. Remove (This removes an item)");
                    Console.WriteLine("3. Check (This checks if an item is present)");
                    Console.WriteLine("4. Search (This searches for an item)");
                    Console.WriteLine("5. IsEmpty (This checks if the list is empty)");
                    Console.WriteLine("6. Size (This shows the number of items in the LinkedList)");
                    Console.WriteLine("7. Insert (This adds an item at a specified position)");
                    Console.WriteLine("8. Index (This returns the index of an item)");
                    Console.WriteLine("9. Exit LinkedList class menu");
                    Console.WriteLine();
                    Console.Write("Please select an operation: ");
                    string selection = Console.ReadLine();

                    if (selection == "1")
                    {
                        Console.Write("Please enter a value to add: ");
                        entry = Console.ReadLine();
                        int size = myList.Add(entry);
                        Console.WriteLine();
                        Console.WriteLine("Item added!");
                        Console.WriteLine();
                        Console.Write("To see the current list size, enter SIZE. To ignore, type SKIP: ");
                        string returnSize = Console.ReadLine().ToUpper();
                        Console.WriteLine();
                        if (returnSize == "SIZE")
                        {
                            Console.WriteLine($"The LinkedList currently has {size} items in it!");
                        }
                        else
                        {
                            Console.WriteLine("You decided to skip.");
                        }
                    }
                    else if (selection == "2")
                    {
                        Console.Write("Please enter a value to remove: ");
                        entry = Console.ReadLine();
                        bool removed = myList.Remove(entry);
                        Console.WriteLine();
                        if (removed == true)
                        {
                            Console.WriteLine("Item removed!");
                        }
                        else
                        {
                            Console.WriteLine($"Your entry, {entry} was not found in the LinkedList!");
                        }
                    }
                    else if (selection == "3")
                    {
                        Console.Write("Please enter a value to check: ");
                        entry = Console.ReadLine();
                        bool isPresent = myList.Check(entry);
                        Console.WriteLine();
                        if (isPresent == true)
                        {
                            Console.WriteLine($"{entry} is present in the LinkedList.");
                        }
                        else
                        {
                            Console.WriteLine($"{entry} does not exist in the LinkedList.");
                        }
                    }
                    else if (selection == "4")
                    {
                        Console.Write("Please enter a value to search: ");
                        entry = Console.ReadLine();
                        Console.WriteLine();
                        myList.Search(entry);
                    }
                    else if (selection == "5")
                    {
                        bool isEmpty = myList.IsEmpty();
                        if (isEmpty == true)
                        {
                            Console.WriteLine("The LinkedList is empty.");
                        }
                        else
                        {
                            Console.WriteLine("The LinkedList is not empty.");
                        }
                    }
                    else if (selection == "6")
                    {
                        int listSize = myList.Size();
                        Console.WriteLine($"There are {listSize} items currently present in the LinkedList.");
                    }
                    else if (selection == "7")
                    {
                        Console.Write("Please enter a value to insert: ");
                        entry = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Please enter the desired insert position: ");
                        int entryPosition = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        myList.Insert(entry, entryPosition);
                        Console.WriteLine("Item inserted!");
                    }
                    else if (selection == "8")
                    {
                        Console.Write("Please enter the query item value: ");
                        entry = Console.ReadLine();
                        Console.WriteLine();
                        int index = myList.Index(entry);
                        Console.WriteLine($"The query item, {entry} is at index {index} in the LinkedList.");
                    }
                    else if (selection == "9")
                    {
                        inLinkedList = false;
                    }
                    else
                    {
                        Console.WriteLine("Wrong selection. Try again.");
                    }
                }
                Console.WriteLine();
                Console.Write("To continue into the LinkedList class menu, enter YES. To exit the LinkedList class, enter NO: ");
                string inClass = Console.ReadLine().ToUpper();
                if (inClass != "YES")
                {
                    inLinkedListClass = false;
                }
            }
        }
    }
}
