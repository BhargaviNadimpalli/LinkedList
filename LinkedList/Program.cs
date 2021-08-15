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
            list.Add(70);
            Console.WriteLine("The linked list :");
            list.Display();

            list.LastElement();
            Console.WriteLine("After deleting last element :");
            list.Display();
        }
    }
}
