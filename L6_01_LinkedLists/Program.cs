using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_01_LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> list = new LinkedList<string>();

            list.Add("Hi");
            list.Add(" Cesar");
            list.Add(",");
            list.Add(" how");
            list.Add(" are");
            list.Add(" you?");

            Console.WriteLine(list.GetFirst);
            Console.WriteLine(list.GetLast);

            Console.WriteLine(list.ToString());

            list.RemoveFirst(" Cesar");

            Console.WriteLine(list.ToString());

            LinkedList<int> list2 = new LinkedList<int>();

            list2.Add(1);
            list2.Add(23);
            list2.Add(45);

            Console.WriteLine(list2.GetFirst);
            Console.WriteLine(list2.GetLast);

            Console.WriteLine(list2.ToString());

            list2.RemoveFirst(23);

            Console.WriteLine(list2.ToString());

        }
    }
}
