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
            linkedListNode.Add(70);
            linkedListNode.AddPosition(1,30);
            linkedListNode.Show();
            linkedListNode.RemoveLast();
            Console.WriteLine();
            linkedListNode.Show();
            Console.WriteLine(linkedListNode.Search(30));
        }
    }
}
