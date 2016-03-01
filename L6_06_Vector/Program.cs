using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_06_Vector
{
    class Program
    {
        static void Main(string[] args)
        {

            Vector v1 = new Vector(1, 1, 1);

            Vector v2 = new Vector(2, 3, 4);

            Console.WriteLine(v1);
            Console.WriteLine(v2);

            Console.WriteLine(v1 + v2);
            Console.WriteLine(v1 - v2);
            Console.WriteLine(v1 * v2);
            Console.WriteLine(v1 / v2);

        }
    }
}
