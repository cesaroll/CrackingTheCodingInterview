using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_08_HashTable
{
    class HashTable<K,V> where K : IComparable<K>
    {

        private Node head;
        private int count;

        private Node _workingNode;
        private Node _workingParent;
        private bool found;

        StringBuilder sb;

        int _compare;

        private Node[] orderedArray;
        private int currIdx;

        //Constructor
        public HashTable()
        {
            head = null;
            count = 0;
        }        

        //Methods
        public bool Find(K key)
        {
            found = false;
            _workingNode = new Node(key, default(V));

            Find(head);

            return found;
        }

        private void Find(Node node)
        {
            if (node != null)
            {
                _compare = node.Key.CompareTo(_workingNode.Key);

                if (_compare == 0)
                {
                    found = true;
                    _workingNode = node;
                }
                else
                    if (_compare < 0)
                        Find(node.RightChild);
                    else
                        Find(node.LeftChild);
            }

        }

        public V GetValue(K key, out bool wasFound)
        {
            found = false;
            _workingNode = new Node(key, default(V));

            Find(head);

            wasFound = found;

            if (found)
                return _workingNode.Value;
            else
                return default(V);

        }


        //Methods

        /// <summary>
        /// Add Key and Value pair
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(K key, V value)
        {
            _workingNode = new Node(key, value);
            _workingParent = null;
            Add(ref head);
        }

        private void Add(ref Node node)
	    {
		    if(node == null)
		    {
                node = new Node(_workingNode, _workingParent);
                count++;
		    }
		    else
		    {   
                _compare = node.Key.CompareTo(_workingNode.Key);

                if (_compare < 0)
                {
                    _workingParent = node;
                    Add(ref node.RightChild);
                }
                else
                    if (_compare > 0)
                    {
                        _workingParent = node;
                        Add(ref node.LeftChild);
                    }
                    else
                        node.Value = _workingNode.Value;
		    }		
		
	    }

        /// <summary>
        /// Remove Key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Remove(K key)
        {
            if (Find(key))
            {
                Node toRemove = _workingNode;
                Node parent = toRemove.Parent;
                bool reAtachRightChild = false;

                _compare = parent.Key.CompareTo(toRemove.Key);

                if (_compare > 0)
                {
                    // Child belongs to Left Side

                    if (toRemove.LeftChild != null)
                    {
                        parent.LeftChild = toRemove.LeftChild;
                        toRemove.LeftChild.Parent = parent;
                        reAtachRightChild = true;
                    }
                    else
                    {
                        parent.LeftChild = toRemove.RightChild;
                        if (toRemove.RightChild != null)
                            toRemove.RightChild.Parent = parent;
                    }

                }
                else
                {
                    //Child belongs to Right Side

                    if (toRemove.RightChild != null)
                    {
                        parent.RightChild = toRemove.LeftChild;
                        toRemove.LeftChild.Parent = parent;
                        reAtachRightChild = true;
                    }
                    else
                    {
                        parent.RightChild = toRemove.RightChild;
                        if (toRemove.RightChild != null)
                            toRemove.RightChild.Parent = parent;
                    }

                }


                if (reAtachRightChild && toRemove.RightChild != null)
                {
                    _workingParent = parent;
                    _workingNode = toRemove.RightChild;
                    Add(ref parent);
                }


            }

            return false;
        }



        //Traverse InOrder
        public override String ToString()
        {
            sb = new StringBuilder();
            InOrder(ref head);
            return sb.ToString();

        }

        private void InOrder(ref Node current)
        {
            if (current != null)
            {
                InOrder(ref current.LeftChild);
                sb.Append(current.Value).Append(" ");
                InOrder(ref current.RightChild);
            }

        }


        public void ReBalance()
        {
            orderedArray = new Node[count];
            currIdx = 0;
            FillOrderedArray(ref head);

            head = null;
            GetBalancedTree(0, count-1);

        }

        private void FillOrderedArray(ref Node curr)
        {
            if(curr != null)
            {
                FillOrderedArray(ref curr.LeftChild);
                orderedArray[currIdx] = curr;
                currIdx++;
                FillOrderedArray(ref curr.RightChild);
            }
        }


        private int mid;
        private void GetBalancedTree(int low, int high)
        {
            if (high < low) return;

            mid = low + (high - low) / 2;

            _workingNode = orderedArray[mid];
            Add(ref head);

            GetBalancedTree(low, mid - 1);

            GetBalancedTree(mid + 1, high);

        }

        //Inner class Node
        class Node
        {
            private K _key;
            private V _value;
            public Node LeftChild;
            public Node RightChild;
            private Node _parent;
            
            public Node(K key, V value)
                : this(key, value, null)
            {
            }

            public Node(Node node, Node parent) : this(node.Key, node.Value, parent)
            {

            }

            public Node(K key, V value, Node parent)
            {
                _key = key;
                _value = value;
                _parent = parent;
            }
            
                      
            public K Key { get { return _key; } set { _key = value; } }
            public V Value { get { return _value; } set { _value = value; } }
            public Node Parent { get { return _parent; } set { _parent = value; } }

        }

    }
}
