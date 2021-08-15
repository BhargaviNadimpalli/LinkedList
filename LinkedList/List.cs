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




