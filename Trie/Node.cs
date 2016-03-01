using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    class Node
    {
        private char _letter;
        private bool _last;
        private SortedDictionary<char, Node> _children;

        //Constructors
        public Node() : this(' ')
        {
        }

        public Node(char letter)
        {
            Letter = letter;
            Last = false;
            _children = new SortedDictionary<char, Node>();

        }

        //Properties
        public char Letter { get { return _letter; } set { _letter = value; } }

        public bool Last { get { return _last; } set { _last = value; } }

        //public SortedDictionary<char, Node> Children { get {return _children;} set { _children = value;} }

        //Methods
        public Node GetChildNode(char letter)
        {
            if (_children != null && _children.ContainsKey(letter))
                return _children[letter];

            return null;
        }

        public Node AddOrReturn(char letter)
        {
            if (_children.ContainsKey(letter))
                return _children[letter];
            else
            {
                Node newnode = new Node(letter);
                _children.Add(letter, newnode);
                return newnode;
            }
        }

        
    }
}
