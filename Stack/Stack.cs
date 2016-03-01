using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack<T>
    {
        long _count;
        Node tail;

        //Constructor
        public Stack()
        {
            _count = 0;
            tail = null;
        }

        //Properties
        public long Count { get { return _count; } }

        //Methods

        public void Push(T element)
        {            
            Node newNode = new Node(element);

            if(tail == null)
            {
                tail = newNode;
            }
            else
            {
                newNode.Prev = tail;
                tail.Next = newNode;
                tail = newNode;
            }

            _count++;
        }

        public T Pop()
        {
            
            T data = default(T);

            if (_count > 0 && tail != null)
            {
                data = tail.Data;
                tail = tail.Prev;
                _count--;

                if (_count == 0)
                    tail = null; ;

            }            

            return data;
        }

        //Inner class Node
        class Node
        {
            private T _data;
            private Node _next;
            private Node _prev;

            public Node(T data)
            {
                _data = data;
                _next = null;
                _prev = null;
            }

            public T Data { get { return _data; } set { _data = value; } }
            public Node Next { get { return _next; } set { _next = value; } }
            public Node Prev { get { return _prev; } set { _prev = value; } }

        }
    }
}
