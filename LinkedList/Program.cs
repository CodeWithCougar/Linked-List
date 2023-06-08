using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Linked List Data Structure.
            MyLinkedList list= new MyLinkedList();
            list.insertAtEnd(10);
            list.insertAtEnd(100);
            list.insertAtEnd(100);
            list.insertAtEnd(100);
            list.insertAtEnd(-1);
            list.insertAtEnd(1);
            list.insertAtEnd(2);
            list.insertAtEnd(3);
            list.insertAtEnd(4);
            list.insertAtEnd(5);
            list.insertAtEnd(-5);
            list.insertAtEnd(6);
            list.insertAtEnd(-6);
            list.insertAtPos(333, 3);

            //list.deleteDuplicates();

            bool filterEvens(int data)
            {
                return data % 2 == 0;
            }
            bool filterOdds(int data)
            {
                return data % 2 != 0;
            }
            list.DeleteByCondition((data) => data > 0);


            list.print();
            Console.WriteLine("Size: "+ list.size());
            Console.WriteLine("Length: "+ list.length());
        }
    }
}