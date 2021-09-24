using System;
using System.Collections.Generic;

namespace MyDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List!");
            LinkedListNode<int> linkedListNode = new LinkedListNode<int>();
            linkedListNode.Add(56);
            linkedListNode.Add(30);
            linkedListNode.Add(70);
            linkedListNode.Show();
        }
    }
}
