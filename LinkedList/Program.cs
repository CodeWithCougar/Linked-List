using System;
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
            list.insertAtEnd(20);
            list.insertAtEnd(30);
            list.insertAtEnd(40);
            list.insertAtEnd(50);
            list.insertAtEnd(60);
            list.insertAtEnd(70);
            list.insertAtEnd(80);
            list.insertAtEnd(90);
            list.insertAtRandomPos(300);
            


            list.print();
            Console.WriteLine("Size: "+ list.size());
            Console.WriteLine("Length: "+ list.length());
        }
    }
}