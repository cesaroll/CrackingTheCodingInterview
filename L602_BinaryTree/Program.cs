using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L602_BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<string> biTree = new BinaryTree<string>(false);

            biTree.Add("F");
            biTree.Add("B");
            biTree.Add("A");
            biTree.Add("D");

            biTree.Add("C");
            biTree.Add("E");
            biTree.Add("I");
            biTree.Add("H");
            biTree.Add("K");
            biTree.Add("G");
            biTree.Add("J");
            biTree.Add("M");

            biTree.WalkInOrder();
            biTree.WalkPreOrder();
            biTree.WalkPostOrder();

            biTree.Find("Z");
            biTree.Find("A");

            foreach (string item in biTree)
            {
                Console.Write(item);
            }

            Console.WriteLine();


        }
    }
}
