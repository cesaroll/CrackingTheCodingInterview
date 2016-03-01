using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_07_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<String> list = new ArrayList<string>();

            list.Add("Hi");
            list.Add(" Cesar");
            list.Add(",");
            list.Add(" how");
            list.Add(" are");
            list.Add(" you?");

            Console.WriteLine(list.ToString());

            int idx = list.Find(" Cesar");

            list.Delete(idx);

            Console.WriteLine(list.ToString());

            list.Add(" Hi");
            list.Add(" friend,");
            list.Add(" I'm");
            list.Add(" fine");
            list.Add(", and");
            list.Add(" you?");

            Console.WriteLine(list.ToString());


            int count = list.Count;

            for (int i = 2; i < count; i++)
            {
                list.Delete(1);
            }

            list.Shrink();

            Console.WriteLine(list.ToString());

        }
    }
}
