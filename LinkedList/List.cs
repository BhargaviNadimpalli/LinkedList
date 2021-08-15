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
        public void Insert(int position, int data)
        {
            Node node = new Node(data);

            if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }

            else
            {
                Node temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }
        public void Delete(int data)
        {
            Node temp = head, a = null;
            if (temp != null && temp.data == data)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != data)
            {
                a = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            a.next = temp.next;
        }
       
        public int Size()
        {
            Node temp = head;
            int size = 0;
            
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
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




