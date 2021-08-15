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

                //Add Data
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
        }
    }


