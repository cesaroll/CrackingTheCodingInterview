using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_01_LinkedLists
{
    public class ListNode<T> 
    {   

        public ListNode(T d) : this(d, null)
        {
            
        }

        public ListNode(T d, ListNode<T> n)
        {
            Data = d;
            Next = n;
        }

        public T Data { get; set; }

        public ListNode<T> Next { get; set; }


    }
}
