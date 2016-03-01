using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasDuplicates("cesarc"));
            Console.WriteLine(HasDuplicates2("cesarc"));

            int x = 7, y = 2, z, r;
            z = x << y; //left shift operator
            r = x >> y; // right shift operator
            Console.WriteLine("\n z={0}\tr={1} ", z, r);
        }

        public static bool HasDuplicates2(string str)
        {
            int checker = 0;
            int val;

            foreach(char c in str)
            {
                val = c - 'a';
                if ( (checker & (1 << val) ) > 0)
                    return true; // THere are duplicates

                checker |= (1 << val);
            }

            return false;

        }
        public static bool HasDuplicates(String str)
        {
		    if(str.Length > 256) return true;
		
		    bool[] arr = new bool[256];
		
		    foreach(char c in str)
		    {
			    if(arr[c])
				    return true;
			    else
				    arr[c] = true;
		    }
		
		    return false;
		
        }
    }
}
