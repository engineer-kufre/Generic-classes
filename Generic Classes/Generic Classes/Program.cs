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
                    bool inLinkedListClass = true;
                    while (inLinkedListClass == true)
                    {
                        Console.WriteLine("Welcome to the LinkedList class!");
                        Console.WriteLine();
                        GenericLinkedList<string> myList = new GenericLinkedList<string>();
                        Console.Write("Your LinkedList is empty. Enter the value of the first item to begin: ");
                        string entry = Console.ReadLine();
                        myList.Add(entry);
                        bool inLinkedList = true;
                        while (inLinkedList == true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("The operations below are available in the LinkedList class: ");
                            Console.WriteLine("1. Add");
                            Console.WriteLine("2. Remove");
                            Console.WriteLine("3. Check");
                            Console.WriteLine("4. Search");
                            Console.WriteLine("5. IsEmpty");
                            Console.WriteLine("6. Size");
                            Console.WriteLine("7. Insert");
                            Console.WriteLine("8. Index");
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
                if (choice == "0")
                {
                    inApp = false;
                }
            }
            




            // GenericLinkedList<int> myList = new GenericLinkedList<int>();
            // myList.Add(200);
            // myList.Add(300);
            // myList.Add(400);
            // myList.Add(500);
            // Console.WriteLine(myList.Index(500));
            // Console.WriteLine(myList.Size());
            // myList.Remove(400);
            // Console.WriteLine(myList.Check(300));
            //Console.WriteLine(myList.Search(200));
            //Console.WriteLine(myList.Search(400));
            //Console.WriteLine(myList.IsEmpty());
            //Console.WriteLine(myList.Size());
            //myList.Insert(400, 0);
            //Console.WriteLine(myList.Index(400));

            //GenericStack<string> myStack = new GenericStack<string>();
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

            //GenericQueue<string> myQueue = new GenericQueue<string>();
            //myQueue.Enqueue("dog");
            //myQueue.Enqueue("cat");
            //myQueue.Enqueue("fish");
            //myQueue.Enqueue("horse");
            //myQueue.Dequeue();
            //myQueue.Dequeue();
            //Console.WriteLine(myQueue.Size());
            //Console.WriteLine(myQueue.IsEmpty());
        }
    }
}
