using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list programs");
            List list = new List();
            list.Append(56);
          
            list.Append(70);
            list.Insert(2, 30);
            list.Display();
        }
    }
}
