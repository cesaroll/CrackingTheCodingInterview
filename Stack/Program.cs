using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> stack = new Stack<string>();

            stack.Push(" you?");
            stack.Push(" are");
            stack.Push(" how");
            stack.Push(" Cesar,");
            stack.Push("Hi");

            StringBuilder sb = new StringBuilder();
            String s;  

            s = stack.Pop();

            while(s != null)
            {
                sb.Append(s);
                s = stack.Pop();
            }

            Console.WriteLine(sb.ToString());

            stack.Push(" you?");
            stack.Push(" are");
            stack.Push(" how");
            stack.Push(" Cesar,");
            stack.Push("Hi");

            sb = new StringBuilder();
            s = stack.Pop();

            while (s != null)
            {
                sb.Append(s);
                s = stack.Pop();
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
