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
            Console.WriteLine();
            linkedListNode.Show();
            Console.WriteLine(linkedListNode.Search(30));
            linkedListNode.InsertAfter(30,40);
            Console.WriteLine();
            linkedListNode.Show();
            linkedListNode.DeleteElement(40);
            Console.WriteLine();
            linkedListNode.Show();
        }
    }
}
