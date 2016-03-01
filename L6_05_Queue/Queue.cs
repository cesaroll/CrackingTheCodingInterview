using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_05_Queue
{
    class Queue<T>
    {
        Node head;
        Node tail;
        long count;

        //Constructor
        public Queue()
        {
            head = null;
            tail = null;
            count = 0;
        }

        //Methods
        public void Enqueue(T data)
        {
            Node newNode = new Node(data);

            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }

            count++;

        }


        public T Dequeue()
        {
            T data = default(T);

            if (head != null)
            {
                data = head.Data;
                count--;

                if (head.Next != null)
                    head = head.Next;
                else
                {
                    head = null;
                    tail = null;
                }

            }

            return data;

        }


        //Inner Class Node
        class Node
        {
            T _data;
            Node _next;

            public Node(T data)
            {
                _data = data;
            }

            public T Data { get { return _data; } set { _data = value; } }

            public Node Next { get { return _next; } set { _next = value; } }

        }
    }
}
