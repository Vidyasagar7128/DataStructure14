using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataStructure
{
    class LinkedListNode<Gtype>
    {
        private Node<Gtype> head;
        private int count;
        public LinkedListNode()
        {
            this.head = null;
            this.count = 0;
        }
        public bool Empty
        {
            get { return this.count == 0; }
        }
        public int Count
        {
            get { return this.count; }
        }
        public int AddPosition(int index, int d)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException($"Index:{index}");
            }
            if (index > count)
            {
                index = count;
            }
            Node<Gtype> current = this.head;
            if (this.Empty || index == 0)
            {
                this.head = new Node<Gtype>(d, this.head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = new Node<Gtype>(d, current.Next);
            }
            count++;
            return d;
        }
        public int Add(int d)
        {
            return this.AddPosition(count, d);
        }
        public int Get(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException($"Index:{index}");
            if (this.Empty)
                return 0;

            if (index >= this.count)
                index = this.count - 1;

            Node<Gtype> current = this.head;
            for (int i = 0; i < index; i++)
                current = current.Next;

            return current.Data;
        }
        public void Show()
        {
            Node<Gtype> current = this.head;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}