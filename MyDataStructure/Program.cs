using System;
using System.Collections.Generic;

namespace MyDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List!");
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            foreach(int i in linkedList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
