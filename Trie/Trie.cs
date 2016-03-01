using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    class Trie
    {
        private Node head;

        public Trie()
        {
            head = new Node();
        }


        public void Add(String word)
        {
            Node current = head;

            string wordlower = word.ToLower();

            foreach (char c in wordlower)
                current = current.AddOrReturn(c);

            current.Last = true;

        }

        public bool Find(String word)
        {
            Node current = head;
            Node child;

            foreach (char c in word)
            {
                child = current.GetChildNode(c);
                if (child != null)
                    current = child;
                else
                    return false;
            }

            if (current.Last)
                return true;
            else
                return false;

        }
    }
}
