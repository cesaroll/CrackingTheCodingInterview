using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_08_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashTable<int, string> myHash = new HashTable<int, string>();

            //myHash.Add(10, "ten");
            //myHash.Add(1, "one");
            //myHash.Add(4, "four");
            //myHash.Add(20, "twenty");
            //myHash.Add(9, "nine");
            //myHash.Add(15, "fifteen");
            //myHash.Add(25, "twentyfive");
            //myHash.Add(23, "twentytree");
            //myHash.Add(30, "tirty");
            //myHash.Add(29, "twentynine");
            //myHash.Add(40, "forty");
            //myHash.Add(22, "twentyto");
            //myHash.Add(21, "twentyone");
            //myHash.Add(24, "twentyfour");
            //myHash.Add(41, "fortyone");

            HashTable<int, int> myHash = new HashTable<int, int>();
            myHash.Add(1, 1);
            myHash.Add(2, 2);
            myHash.Add(3, 3);
            myHash.Add(4, 4);
            myHash.Add(5, 5);
            myHash.Add(6, 6);
            myHash.Add(7, 7);
            myHash.Add(8, 8);

            Console.WriteLine(myHash.ToString());

            myHash.Remove(23);

            Console.WriteLine(myHash.ToString());

            myHash.ReBalance();

            Console.WriteLine(myHash.ToString());

        }
    }
}
