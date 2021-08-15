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

            list.Insert(3, 40);
            Console.WriteLine("The list after inserting value :");
            list.Display();
        }
    }
}
