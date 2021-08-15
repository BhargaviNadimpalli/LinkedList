using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class List
    {
        internal Node head;
        internal void Add(int data)
        {
            //Object of Node
            Node node = new Node(data);

 
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted in the Linked List", node.data);
        }

        internal Node LastElement()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node node = head;
            while (node.next.next != null)
            {
                node = node.next;
            }
            node.next = null;
            return head;
        }
        internal void Display()
        {
            if (this.head == null)
                Console.WriteLine("list is empty.");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine("Data : " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}


