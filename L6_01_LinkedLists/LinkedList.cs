using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace L6_01_LinkedLists
{
    class LinkedList<T>
    {        
        //Constructors
        public LinkedList()
        {

        }      

        //Class variables
        private ListNode<T> firstNode = null;
        private ListNode<T> lastNode = null;

        //Public Properties
        public ulong Count { get; set; }

        public T GetFirst 
        { 
            get{ 
                if(firstNode != null)
                    return firstNode.Data;
                else
                    return default(T);
            }
        }

        public T GetLast 
        { 
            get{
                if(lastNode != null)
                    return lastNode.Data;
                else
                    return default(T);
            }

        }
       

        /// <summary>
        /// Add Data to end of List
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            ListNode<T> newNode = new ListNode<T>(data);

            if (firstNode == null)
            {
                firstNode = newNode;
                lastNode = newNode;
            }
            else
            {
                lastNode.Next = newNode;
                lastNode = newNode;
            }

            Count++;

        }
        

        /// <summary>
        /// Remove Fist Ocurrence of data
        /// Return true if found and removed
        /// </summary>
        /// <param name="data"></param>
        public bool RemoveFirst(T data)
        {
            if(firstNode == null)
                return false;
            

            ListNode<T> current = firstNode;
            ListNode<T> prev = firstNode;

            while(current != null)
            {
                if(current.Data.Equals(data))
                {
                    if(current == firstNode)
                    {
                        if (firstNode == lastNode)
                            lastNode = firstNode.Next;

                        firstNode = firstNode.Next;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }

                    return true;
                }

                prev = current;
                current = current.Next;

            }


            return false;

        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            ListNode<T> currentNode = firstNode;

            while(currentNode != null)
            {
                sb.Append(currentNode.Data.ToString());
                currentNode = currentNode.Next;
            }

            return sb.ToString();

        }

    }
}
