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
        public int Remove(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException($"Index:{index}");
            }
            if (this.Empty)
                return 0;

            if (index >= this.count)
            {
                Console.WriteLine($"Can not Delete by {index} Index");
            }
            Node<Gtype> current = this.head;
            int result = 0;
            if (index == 0)
            {
                result = current.Data;
                this.head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;
                result = current.Next.Data;

                current.Next = current.Next.Next;
            }
            count--;
            return result;
        }
        public int RemoveFirst()
        {
            return this.Remove(0);
        }
        public int RemoveLast()
        {
            return this.Remove(count - 1);
        }
        public bool Search(int val)
        {
            Node<Gtype> current = this.head;
            for (int i=0; i < count; i++)
            {
                if (current.Data.Equals(val))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
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