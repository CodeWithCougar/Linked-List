using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class MyLinkedList
    {
        private Node head; // reference to the head (first) node in the list
        private Node tail; // reference to the tail (last) node in the list
        private int len; // length of the linked list


        public MyLinkedList() 
        {
            this.head = this.tail = null; // initializing the list with null head nad tail (Emtpty list)
            this.len = 0; 
        }

        public void insertAtEnd(int data)
        {
            // Created a new node with the given data.
            Node newNode = new Node(data);
            if(this.head == null) 
            {
                // if the list is empty, make the new node the head node
                this.head = this.tail = newNode;
                len++;
            }
            else
            {
                //Node temp= this.head;
                //while(temp.Next !=null)
                //{
                //    temp = temp.Next;
                //}
                //temp.Next = newNode;
                tail.Next= newNode;
                tail = newNode;
                len++;
            } 
        }

        public void insertAfter(int target, int data)
        {
            // Create a new node with the given data.
            Node newNode = new Node(data); 

            // Iterate through the linked list while the current
            // node isn't null and doesn't match the "target" value.
            Node temp = head;
            while (temp != null && temp.Data != target)
            {
                temp = temp.Next;  // Move to the next node.
            }

            // If the "target" node was found,
            // insert the new node target it.
            if (temp != null && temp.Data == target)
            {
                newNode.Next = temp.Next;  // The next node of the new node is the current next node of the "target" node.
                temp.Next = newNode;  // The next node of the "target" node is the new node.
                len++;
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }

        public void insertBefore(int target, int data)
        {
            // Create a new node with the given data.
            Node newNode = new Node(data);  

            // Check if the list is empty. If so, print a message and return.
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // Special case: If the head node is the "target" node, adjust the head and return.
            if (head.Data == target)
            {
                newNode.Next = head;  // The next node of the new node is the current head.
                head = newNode;  // The new head is the new node.
                len++;
                return;
            }

            // Iterate through the linked list while the current node isn't null and doesn't match the "target" value.
            Node cur = head;
            Node prev = null;
            while (cur != null && 
                cur.Data != target)
            {
                prev = cur;  // Save the current node as the previous node.
                cur = cur.Next;  // Move to the next node.
            }

            // If the "target" node was found, insert the new node target it.
            if (cur != null)
            {
                prev.Next = newNode;  // The next node of the previous node is the new node.
                newNode.Next = cur;  // The next node of the new node is the "target" node.
                len++;
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }

        public void insertAtBeginning(int data) 
        {   
            Node newNode = new Node(data);
            if(isEmpty())
            {
                this.head = this.tail = newNode;
                len++;
            }
            else
            {
                newNode.Next = head;
                this.head = newNode;
                len++;
            }
        }

        public void insertAtPos(int data, int pos)
        {
            Node newNode = new Node(data);
            if( pos < 1 || pos > size() + 1)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            if(pos == size() + 1)
            {
                insertAtEnd(data);
                return;
            }
            if(pos == 1)
            {
                insertAtBeginning(data);
                return;
            }
            int counter = 1; 
            Node temp = head;

            while(counter < pos -1) // O(n) 
            {
                counter++;
                temp = temp.Next;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;
            len++;
        }

        public void insertAtRandomPos(int data)
        {
            Random random= new Random();

            int pos = random.Next(1 , this.len);
            insertAtPos(data, pos+1);
        }
        public bool isEmpty()
        { return this.head == null; }
        public void print()
        {
            Node temp= this.head;

            if(this.head ==null)
            {
                Console.WriteLine("The list is empty");
                return;
            }

            while(temp != null) 
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
        public int size() // O(n)
        {
            int size  = 0;
            Node temp = this.head;
            while(temp != null)
            {
                size++;
                temp = temp.Next;
            }
            return size;
        }

        public int length() // O(1)
        {
            return this.len;
        }
    }
}
