using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace L602_BinaryTree
{
    class BinaryTree<T>
    {
        //Constructor

        public BinaryTree(bool allowDups)
        {
            this.allowDups = allowDups;
        }

        //Class variables	

        bool allowDups;
        
        TreeItem head = null;
        int compare;

        TreeItem workingItem;


        #region TreeItem
        class TreeItem
        {            
            public TreeItem(T data)
            {
                Data = data;
            }

            public T Data;
            public TreeItem Parent;
            public TreeItem LeftChild;
            public TreeItem RightChild;
        }
        #endregion

        #region Add Data to the Binary Tree
        public void Add(T data)
        {
            workingItem = new TreeItem(data);

            AddNode(ref head, null);

        }

        //Private Method to Add Node recursivly
        private void AddNode(ref TreeItem ti, TreeItem parent)
        {
            if (ti == null)
            {
                ti = workingItem;
                ti.Parent = parent;
            }
            else
            {
                compare = ti.Data.ToString().CompareTo(workingItem.Data.ToString());

                if (compare > 0) //ti is bigger, add to left child
                    AddNode(ref ti.LeftChild, ti);
                else if (compare < 0) //ti is smaller, add to right child
                    AddNode(ref ti.RightChild, ti);
                else if (allowDups)
                    AddNode(ref ti.RightChild, ti);
            }

        }

        #endregion

        #region Traversing the Tree

        public void WalkInOrder()
        {
            Console.Write("WalkInOrder:   ");
            InOrder(head);
            Console.WriteLine();
        }

        public void WalkPreOrder()
        {
            Console.Write("WalkPreOrder:  ");
            PreOrder(head);
            Console.WriteLine();
        }

        public void WalkPostOrder()
        {
            Console.Write("WalkPostOrder: ");
            PostOrder(head);
            Console.WriteLine();
        }


        private void InOrder(TreeItem ti)
	    {
		    if(ti != null)
		    {
                InOrder(ti.LeftChild);
			    Console.Write(ti.Data.ToString());
			    InOrder(ti.RightChild);
		    }
	    }

        private void PreOrder(TreeItem ti)
	    {
		    if(ti != null)
		    {	
			    Console.Write(ti.Data.ToString());
                PreOrder(ti.LeftChild);		
			    PreOrder(ti.RightChild);
		    }
	    }

        private void PostOrder(TreeItem ti)
	    {
		    if(ti != null)
		    {
                PostOrder(ti.LeftChild);
                PostOrder(ti.RightChild);
			    Console.Write(ti.Data.ToString());
			
		    }
        }
        
        #endregion


        #region Find

        public void Find(T data)
        {
            workingItem = new TreeItem(data);

            if(FindNode(ref head))
                Console.WriteLine(" {0} was found!", data.ToString());
            else
                Console.WriteLine(" {0} was not found!", data.ToString());
        }

        private bool FindNode(ref TreeItem ti)
        {
            if (ti != null)
            {
                compare = ti.Data.ToString().CompareTo(workingItem.Data.ToString());

                if (compare == 0) //Curretn is equal return true
                    return true;
                else if (compare > 0) //Current is bigger, search left child
                    return FindNode(ref ti.LeftChild);
                else  //Current si smaller, search righ child
                    return FindNode(ref ti.RightChild);
            }
            else
                return false;
        }

        #endregion


        #region Implement IEnumerator

        public IEnumerator<T> GetEnumerator()
        {
            return new BinaryTreeEnumerator(this);
        }

        class BinaryTreeEnumerator : IEnumerator<T>
        {
            TreeItem current;
            BinaryTree<T> theTree;
            bool found;

            public BinaryTreeEnumerator(BinaryTree<T> tree)
            {
                theTree = tree;
                current = null;
            }

            public T Current
            {
                get
                {
                    if (current == null)
                        throw new InvalidOperationException();
                    return current.Data;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    if (current == null)
                        throw new InvalidOperationException();
                    return current.Data;
                }
            }

            void IEnumerator.Reset() { current = null; }

            public void Dispose() { }
            public bool MoveNext()
            {
                found = false;

                InOrder(theTree.head);

                return found;

            }

            private void InOrder(TreeItem ti)
            {
                if (ti != null)
                {
                    InOrder(ti.LeftChild);

                    if (current == null)
                    {
                        current = ti;
                        found = true;
                        return;
                    }

                    if (!found )
                    {
                        int compare = ti.Data.ToString().CompareTo(current.Data.ToString());

                        if (compare > 0)
                        {
                            current = ti;
                            found = true;
                            return;
                        }
                        else if(compare <= 0)
                        {
                           InOrder(ti.RightChild);
                        }
                        
                    }

                    
                }

            }


        }

        #endregion

    }
}
