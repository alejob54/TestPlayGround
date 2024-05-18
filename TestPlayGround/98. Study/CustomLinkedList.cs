using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlayGround._98._Study
{
    public class CustomLinkedList
    {
        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        public class LinkedList<T>
        {
            private Node<T> Head;

            public void Add(T data)
            {
                Node<T> newNode = new Node<T>(data);
                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    Node<T> current = Head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }

            public int Count()
            {
                int count = 0;
                Node<T> current = Head;
                while (current != null)
                {
                    count++;
                    current = current.Next;
                }

                return count;
            }

            public void Print()
            {
                Node<T> current = Head;
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
            }
        }
    }
}
