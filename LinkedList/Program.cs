using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Linked List Data Structure.
            MyLinkedList list= new MyLinkedList();
            list.inserAtEnd(3);
            list.inserAtEnd(8);
            list.inserAtEnd(15);
            list.inserAtEnd(30);
            list.print();
        }
    }
}