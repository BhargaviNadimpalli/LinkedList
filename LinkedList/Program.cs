using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list programs");
            List list = new List();
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            Console.WriteLine("The list in ascending order :");
            list.Display();
            ///inserting the value
           // list.Insert(3, 40);
           // Console.WriteLine("After inserting the value :");
           // list.Display();
           /////deleting the value
           // list.Delete(40);
           // Console.WriteLine("After deleting the value :");
           // list.Display();

           // ///size of linkedlist
           // list.Size();
           // Console.WriteLine("The size of linkedlist is : ");
           // list.Display();
        }
    }
}
