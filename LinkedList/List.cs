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

        internal Node Search(int value)
        {
            int index = 0;
            while (this.head != null)
            {
                index++;
                if (this.head.data == value)
                {
                    
                    Console.WriteLine(value + " the value is in "+ index + " place");
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
           
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


