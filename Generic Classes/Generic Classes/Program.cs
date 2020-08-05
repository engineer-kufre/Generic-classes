using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inApp = true; //variable to check that the app is online
            while (inApp == true)
            {
                inApp = RunApp(inApp); //call app helper method
            }
        }

        //app helper method
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
                LinkedList(); //call LinkedList method to access GenericLinkedList class operations
            }
            if (choice == "2")
            {
                StackMethod(); //call StackMethod method to access GenericStack class operations
            }
            if (choice == "3")
            {
                QueueMethod(); //call QueueMethod method to access GenericQueue class operations
            }
            if (choice == "0")
            {
                inApp = false; //sets variable to false to turn app offline
            }

            return inApp;
        }


        //Queue helper method
        private static void QueueMethod()
        {
            bool inQueueClass = true;
            while (inQueueClass == true) //user stays in Queue Class until set to false
            {
                Console.WriteLine("Welcome to the Queue class!");
                Console.WriteLine();
                GenericQueue<string> myQueue = new GenericQueue<string>();
                Console.Write("Your Queue is empty. Enter the value of the first item to begin: "); //the first operation on the queue must be enqueue
                string entry = Console.ReadLine();
                myQueue.Enqueue(entry);
                Console.WriteLine();
                myQueue.Print("Item added!");
                Console.WriteLine("--------------------------------------------------------------------------------");
                bool inQueue = true;
                while (inQueue == true) //user stays in the Queue operations loop until set to false
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

                    if (selection == "1") //selection to Enqueue item
                    {
                        Console.Write("Please enter a value to enqueue: ");
                        entry = Console.ReadLine();
                        myQueue.Enqueue(entry);
                        Console.WriteLine();
                        myQueue.Print("Item added!");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "2") //selection to Dequeue item
                    {
                        string dequeued = myQueue.Dequeue();
                        Console.WriteLine();
                        myQueue.Print($"{dequeued} was removed from the Queue!");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "3") //selection to know if the Queue is empty
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
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "4") // selection to know the number of items in the Queue
                    {
                        int queueSize = myQueue.Size();
                        myQueue.Print($"There are {queueSize} items currently present in the Queue.");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "5") // selection to exit the Queue operations loop
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
                if (inClass != "YES") // any string other than "YES" will exit the Queue class
                {
                    inQueueClass = false;
                }
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
        }

        //Stack helper method
        private static void StackMethod()
        {
            bool inStackClass = true;
            while (inStackClass == true) //user stays in Stack Class until set to false
            {
                Console.WriteLine("Welcome to the Stack class!");
                Console.WriteLine();
                GenericStack<string> myStack = new GenericStack<string>();
                Console.Write("Your Stack is empty. Enter the value of the first item to begin: "); //the first operation on the stack must be Push
                string entry = Console.ReadLine();
                myStack.Push(entry);
                Console.WriteLine();
                myStack.Print("Item added!");
                Console.WriteLine("--------------------------------------------------------------------------------");
                bool inStack = true;
                while (inStack == true) //user stays in the Stack operations loop until set to false
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

                    if (selection == "1") //selection to Push item
                    {
                        Console.Write("Please enter a value to add: ");
                        entry = Console.ReadLine();
                        myStack.Push(entry);
                        Console.WriteLine();
                        myStack.Print("Item added!");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "2") //selection to Pop item
                    {
                        string popped = myStack.Pop();
                        Console.WriteLine();
                        myStack.Print($"{popped} was removed from the stack!");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "3") //selection to return last item in the stack
                    {
                        string peeked = myStack.Peek();
                        Console.WriteLine();
                        if (peeked == default)
                        {
                            myStack.Print("The stack is currently empty!");
                        }
                        else
                        {
                            myStack.Print($"{peeked} is currently the last item in the stack!");
                        }
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "4") //selection to know if the Stack is empty
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
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "5") // selection to know the number of items in the Stack
                    {
                        int stackSize = myStack.Size();
                        myStack.Print($"There are {stackSize} items currently present in the Stack.");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "6") // selection to exit the Stack operations loop
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
                if (inClass != "YES") // any string other than "YES" will exit the Stack class
                {
                    inStackClass = false;
                }
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
        }

        //LinkedList helper method
        private static void LinkedList()
        {
            bool inLinkedListClass = true;
            while (inLinkedListClass == true) //user stays in LinkedList Class until set to false
            {
                Console.WriteLine("Welcome to the LinkedList class!");
                Console.WriteLine();
                GenericLinkedList<string> myList = new GenericLinkedList<string>();
                Console.Write("Your LinkedList is empty. Enter the value of the first item to begin: "); //the first operation on the LinkedList must be Add
                string entry = Console.ReadLine();
                myList.Add(entry);
                Console.WriteLine();
                Console.WriteLine("Item added!");
                Console.WriteLine("--------------------------------------------------------------------------------");
                bool inLinkedList = true;
                while (inLinkedList == true) //user stays in the LinkedList operations loop until set to false
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

                    if (selection == "1") //selection to Add item
                    {
                        Console.Write("Please enter a value to add: ");
                        entry = Console.ReadLine();
                        int size = myList.Add(entry);
                        Console.WriteLine();
                        Console.WriteLine("Item added!");
                        Console.WriteLine();
                        Console.Write("To see the current list size, enter SIZE. To ignore, enter SKIP: "); //user can optionally view current LinkedList size
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
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "2") //selection to Remove a specified item
                    {
                        Console.Write("Please enter a value to remove: ");
                        entry = Console.ReadLine();
                        bool removed = myList.Remove(entry);
                        Console.WriteLine();
                        if (removed == true) //program will indicate whether the item was removed or not found
                        {
                            Console.WriteLine("Item removed!");
                        }
                        else
                        {
                            Console.WriteLine($"Your entry, {entry} was not found in the LinkedList!");
                        }
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "3") //selection to check that an item exists in the List
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
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "4") //selection to search that an item exists in the List and returns the item's value
                    {
                        Console.Write("Please enter a value to search: ");
                        entry = Console.ReadLine();
                        Console.WriteLine();
                        myList.Search(entry);
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "5") //selection to know if the LinkedList is empty
                    {
                        bool isEmpty = myList.IsEmpty();
                        Console.WriteLine();
                        if (isEmpty == true)
                        {
                            Console.WriteLine("The LinkedList is empty.");
                        }
                        else
                        {
                            Console.WriteLine("The LinkedList is not empty.");
                        }
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "6") // selection to know the number of items in the LinkedList
                    {
                        int listSize = myList.Size();
                        Console.WriteLine();
                        Console.WriteLine($"There are {listSize} items currently present in the LinkedList.");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "7") // selection to insert a specified item value as a node at the specified index
                    {
                        Console.Write("Please enter a value to insert: ");
                        entry = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Please enter the desired insert position: ");
                        int entryPosition = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        myList.Insert(entry, entryPosition);
                        Console.WriteLine("Item inserted!");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "8") // selection to know an item's index
                    {
                        Console.Write("Please enter the query item value: ");
                        entry = Console.ReadLine();
                        Console.WriteLine();
                        int index = myList.Index(entry);
                        if (index == -1)
                        {
                            Console.WriteLine($"The query item, {entry} does not exist in the LinkedList.");
                        }
                        else
                        {
                            Console.WriteLine($"The query item, {entry} is at index {index} in the LinkedList.");
                        }
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    else if (selection == "9") // selection to exit the LinkedList operations loop
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
                if (inClass != "YES") // any string other than "YES" will exit the LinkedList class
                {
                    inLinkedListClass = false;
                }
            }
        }
    }
}
