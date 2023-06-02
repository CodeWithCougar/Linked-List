using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class MyLinkedList
    {
        private Node head;

        public MyLinkedList() 
        {
            this.head = null;
        }

        public void inserAtEnd(int data)
        {
            Node newNode = new Node(data);
            if(this.head == null) 
            {
                this.head = newNode;
            }
            else
            {
                Node temp= this.head;
                while(temp.Next !=null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        public void print()
        {
            Node tem= this.head;

            if(this.head ==null)
            {
                Console.WriteLine("The list is empty");
                return;
            }

            while(tem != null) 
            {
                Console.Write(tem.Data + " -> ");
                tem = tem.Next;
            }
        }
    }
}
